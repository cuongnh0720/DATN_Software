using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace MyAppDesign
{
    public partial class MyAppDesign : Form
    {
        private StringBuilder buffer = new StringBuilder(); // Su dung StringBuilder de toi uu buffer
        private Task dataProcessingTask;
        private CancellationTokenSource cts;

        // Dictionary de anh xa tu khoa voi hanh dong xu ly du lieu tuong ung
        private Dictionary<string, Action<string>> dataHandlers;

        public MyAppDesign()
        {
            InitializeComponent();
            this.ClientSize = new Size(940, 740);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Cai dat cac gia tri cho ComboBox
            string[] baudrate = { "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
            cboBaudrate.Items.AddRange(baudrate);

            string[] dataSize = { "7", "8" };
            cboDataSize.Items.AddRange(dataSize);

            string[] parity = { "None", "Even", "Odd", "Mark", "Space" };
            cboParity.Items.AddRange(parity);

            string[] maximumOutputPower = { "-4", "-1", "+2", "+5" };
            cboMaximumOutputPower.Items.AddRange(maximumOutputPower);

            string[] dutyCycle = { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" };
            cboDutyCycle.Items.AddRange(dutyCycle);

            string[] LED7Segment = { "Temperature", "Humidity" };
            cboLED7Segment.Items.AddRange(LED7Segment);

            // Khoi tao cac handler xu ly du lieu tuong ung
            dataHandlers = new Dictionary<string, Action<string>>()
            {
                { "HUM", value => txtHumidity.Text = value },
                { "TEMP", value => txtTemperature.Text = value },
                { "LO_LOAD_VOLTAGE_V", value => txtLoadVoltage.Text = value },
                { "LO_CURRENT_MA", value => txtCurrent.Text = value },
                { "LO_POWER_MW", value => txtPower.Text = value },
                { "ADC_DISTORTION_VOLTAGE_V", value => txtADCVoltageDistortion.Text = value },
                { "ADC_DEVIATION", value => txtADCDeviation.Text = value },
                { "ADC_VOLTAGE_V", value => txtADCVoltage.Text = value },
                { "OUTPUT_POWER", value => txtOutputPower.Text = value },
                { "SLOPE", value => txtSlope.Text = value },
                { "INTERCEPT", value => txtIntercept.Text = value }
            };

            // Dang ky su kien nhan du lieu tu SerialPort
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceivedHandler);
        }

        private void MyAppDesign_Load(object sender, EventArgs e)
        {
            cboName.DataSource = SerialPort.GetPortNames();
            cboBaudrate.Text = "115200";
            cboDataSize.Text = "8";
            cboParity.Text = "None";
            cboMaximumOutputPower.Text = "+5";
            cboDutyCycle.Text = "0";
            cboLED7Segment.Text = "Temperature";

            // Khoi dong luong xu ly du lieu khong dong bo
            cts = new CancellationTokenSource();
            dataProcessingTask = Task.Run(() => ProcessDataFromBuffer(cts.Token), cts.Token);
        }

        private void MyAppDesign_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Huy tac vu khi form dong va giai phong tai nguyen
            cts.Cancel();
            dataProcessingTask.Wait();
            cts.Dispose();
        }

        // Ham kiem tra ket noi SerialPort
        private bool CheckSerialPortConnection()
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Serial port not connected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Ham gui du lieu qua SerialPort
        private void SendData(string dataToSend)
        {
            try
            {
                serialPort.WriteLine(dataToSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ham xu ly khi nhan du lieu tu SerialPort
        private void SerialPortDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // Nhan du lieu va dua vao buffer
            string inputData = serialPort.ReadExisting();
            lock (buffer)
            {
                buffer.Append(inputData);
            }
        }

        // Xu ly du lieu tu buffer khong dong bo
        private async Task ProcessDataFromBuffer(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                string localBuffer = "";
                lock (buffer)
                {
                    localBuffer = buffer.ToString();
                    buffer.Clear();
                }

                if (!string.IsNullOrEmpty(localBuffer))
                {
                    string[] lines = localBuffer.Split('\n');

                    for (int i = 0; i < lines.Length - 1; i++)
                    {
                        string line = lines[i].Trim();
                        await ProcessData(line); // Goi xu ly tung dong du lieu
                    }

                    // Giu lai phan chua hoan chinh
                    //lock (buffer)
                    //{
                    //    buffer.Append(lines[lines.Length - 1]);
                    //}
                }

                // Nghi 5ms giua cac lan xu ly de tranh qua tai CPU
                await Task.Delay(5);
            }
        }

        // Xu ly du lieu nhan duoc tu buffer
        private async Task ProcessData(string input)
        {
            // Bo qua xu ly neu chuoi la dang "Hello from task X"
            if (input.StartsWith("Hello from Task"))
            {
                return; // Khong lam gi ca neu chuoi bat dau bang "Hello from task"
            }

            // Kiem tra neu chuoi bat dau voi "Response:"
            if (input.StartsWith("Response:"))
            {
                // Loai bo "Response:" va hien thi phan con lai trong txtResponse
                string responseValue = input.Substring("Response:".Length).Trim();
                await Task.Run(() =>
                {
                    this.Invoke(new Action(() => txtResponse.Text = responseValue));
                });
                return;
            }

            // Neu co dau ':', tien hanh tach va xu ly
            string[] parts = input.Split(':');
            if (parts.Length == 2)
            {
                string key = parts[0].Trim();
                string value = parts[1].Trim();

                // Xu ly du lieu voi Dictionary
                if (dataHandlers.TryGetValue(key, out var handler))
                {
                    // Cap nhat UI phai tren thread chinh
                    await Task.Run(() =>
                    {
                        this.Invoke(new Action(() => handler(value)));
                    });
                }
                //else
                //{
                //    // Neu khong co tu khoa, hien thi du lieu trong txtResponse
                //    await Task.Run(() =>
                //    {
                //        this.Invoke(new Action(() => txtResponse.Text = input));
                //    });
                //}
            }
        }

        // Xu ly khi an nut btnOpen
        private void btnOpen_Click(object sender, EventArgs e)
        {
            cboName.DataSource = SerialPort.GetPortNames();

            // Lay danh sach cac cong COM kha dung
            string[] availablePorts = SerialPort.GetPortNames();

            // Kiem tra neu khong co cong COM nao kha dung
            if (availablePorts.Length == 0)
            {
                MessageBox.Show("No COM ports available. Please connect a device.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiem tra neu cong COM chua duoc chon
            if (string.IsNullOrEmpty(cboName.Text))
            {
                MessageBox.Show("Please select a COM port from the dropdown.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thuc hien ket noi cong COM neu co cong kha dung
            if (!serialPort.IsOpen)
            {
                try
                {
                    // Dat cac thuoc tinh cua SerialPort
                    serialPort.PortName = cboName.Text;
                    serialPort.BaudRate = Convert.ToInt32(cboBaudrate.Text);
                    serialPort.DataBits = Convert.ToInt32(cboDataSize.Text);

                    // Thiet lap Parity tu ComboBox
                    switch (cboParity.Text)
                    {
                        case "None":
                            serialPort.Parity = Parity.None;
                            break;
                        case "Even":
                            serialPort.Parity = Parity.Even;
                            break;
                        case "Odd":
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Mark":
                            serialPort.Parity = Parity.Mark;
                            break;
                        default:
                            serialPort.Parity = Parity.Space;
                            break;
                    }

                    serialPort.Open();
                    btnOpen.Text = "Close"; // Thay doi text nut thanh Close sau khi ket noi thanh cong
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open COM port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Dong cong COM neu dang mo
                serialPort.Close();
                btnOpen.Text = "Open";
            }
        }

        // Xu ly su kien khi an nut btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Xu ly su kien khi an nut btnSendRFOuput
        private void btnSendRFOuput_Click(object sender, EventArgs e)
        {
            if (!CheckSerialPortConnection())
                return;

            // Kiem tra neu TextBox rfOutputValue rong
            string rfOutputValue = txtRFOutput.Text.Trim();
            if (string.IsNullOrEmpty(rfOutputValue))
            {
                MessageBox.Show("Please enter a valid RF Output value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dataToSend = "RF_OUTPUT " + rfOutputValue;
            SendData(dataToSend);
        }

        // Xu ly su kien khi an nut btnSendMaximumOutputPower
        private void btnSendMaximumOuputPower_Click(object sender, EventArgs e)
        {
            if (!CheckSerialPortConnection())
                return;

            // Lay gia tri tu cboMaximumOutputPower
            string maxOutputPowerValue = cboMaximumOutputPower.SelectedItem.ToString();

            string dataToSend = "MAXIMUM_OUTPUT_POWER " + maxOutputPowerValue;
            SendData(dataToSend);
        }

        // Xu ly su kien khi an nut btnSendDutyCycle
        private void btnSendDutyCycle_Click(object sender, EventArgs e)
        {
            if (!CheckSerialPortConnection())
                return;

            // Lay gia tri tu cboDutyCycle
            string dutyCycleValue = cboDutyCycle.SelectedItem.ToString();

            string dataToSend = "DUTY_CYCLE " + dutyCycleValue;
            SendData(dataToSend);
        }

        // Xu ly su kien khi an nut btnSendLED7Segment
        private void btnSendLED7Segment_Click(object sender, EventArgs e)
        {
            if (!CheckSerialPortConnection())
                return;

            // Lay gia tri tu cboLED7Segment
            string selectedValue = cboLED7Segment.SelectedItem.ToString();

            var dataMap = new Dictionary<string, string>
            {
                { "Temperature", "TEMPERATURE" },
                { "Humidity", "HUMIDITY" }
            };

            if (dataMap.TryGetValue(selectedValue, out string dataToSend))
            {
                SendData(dataToSend);
            }
        }
    }
}