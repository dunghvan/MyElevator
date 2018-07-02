using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyElevator
{
    public partial class Form1 : Form
    {
        int NowIsAt = 0;
        int fromFloor = 0;
        int GotoFloor = 0;
        Elevator noruElevator;
        Elevator ele1 = new Elevator(1);
        Elevator ele2 = new Elevator(1);
        Elevator ele3 = new Elevator(1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvEle1.RowCount = 10;            
            dtgvEle1.Rows[(10-ele1.CurrentFloor)].Cells[0].Value = "○";
            dtgvEle1.Rows[(10 - ele2.CurrentFloor)].Cells[1].Value = "○";
            dtgvEle1.Rows[(10 - ele3.CurrentFloor)].Cells[2].Value = "○";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ele1.CurrentFloor = ele2.CurrentFloor = ele3.CurrentFloor = 1;
            ele1.DoorStatus = ele2.DoorStatus = ele3.DoorStatus = false;
            cbGoTo.Text = cmbNowIsAt.Text = "--0--";
            txtMainLog.Text = "";
            loadGridview();
            gbNowAt.Enabled = true;
            dtgvEle1.Enabled = true;
        }

        private void btCallElevator_Click(object sender, EventArgs e)
        {
            NowIsAt = Int32.Parse(cmbNowIsAt.SelectedItem.ToString());
            CallElevator(NowIsAt);
            ele1.DoorStatus = ele2.DoorStatus = ele3.DoorStatus = false;
            gboxInside.Enabled = true;
        }
        public void CallElevator(int nowAt)
        {
            int spaceToEle1 = Math.Abs(NowIsAt- ele1.CurrentFloor);
            int spaceToEle2 = Math.Abs(NowIsAt - ele2.CurrentFloor);
            int spaceToEle3 = Math.Abs(NowIsAt - ele3.CurrentFloor);
            if ((spaceToEle1 <= spaceToEle2) && (spaceToEle1 <= spaceToEle3)) {
                if (spaceToEle1 == spaceToEle2)
                {
                    if(ele1.CurrentFloor > ele2.CurrentFloor)
                    {
                        Call(1);
                    }
                    else
                    {
                        Call(2);
                    }
                }else if (spaceToEle1 == spaceToEle3)
                {
                    if (ele1.CurrentFloor > ele3.CurrentFloor)
                    {
                        Call(1);
                    }
                    else
                    {
                        Call(3);
                    }
                }
                else
                {
                    Call(1);                    
                }
            }else if (spaceToEle2 < spaceToEle3)
            {
                Call(2);
            }else if (spaceToEle2 == spaceToEle3)
            {
                if (ele2.CurrentFloor > ele3.CurrentFloor)
                {
                    Call(2);
                }
                else
                {
                    Call(3);
                }
            }
            else
            {
                Call(3);
            }            
        }
        public void Call(int ele)
        {           
            switch (ele)
            {
                case 1:
                    noruElevator = ele1;
                    fromFloor = ele1.CurrentFloor;
                    txtMainLog.Text += ">> エレベーター I が " + NowIsAt.ToString() + "階へ向かって来ます...\r\n";
                    timer1.Start();
                    break;
                case 2:
                    noruElevator = ele2;
                    txtMainLog.Text += ">> エレベーター II が " + NowIsAt.ToString() + "階へ向かって来ます...\r\n";
                    fromFloor = ele2.CurrentFloor;
                    timer2.Start();
                    break;
                case 3:
                    noruElevator = ele3;
                    txtMainLog.Text += ">> エレベーター III が " + NowIsAt.ToString() + "階へ向かって来ます...\r\n";
                    fromFloor = ele3.CurrentFloor;
                    timer3.Start();
                    break;
                default:                    
                    break;
            }
        }
        public void loadGridview()
        {
            RefeshGridview();
            dtgvEle1.Rows[(10 - ele1.CurrentFloor)].Cells[0].Value = "○";
            dtgvEle1.Rows[(10 - ele2.CurrentFloor)].Cells[1].Value = "○";
            dtgvEle1.Rows[(10 - ele3.CurrentFloor)].Cells[2].Value = "○";
        }
        public void OpenDoor()
        {
            txtMainLog.Text += ">> エレベーターが着ました !!\r\n";
            txtMainLog.Text += ">> ドーアが開いています...\r\n";
            LoadLabel();
            gboxInside.Visible = true;

        }
        public void RefeshGridview()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    dtgvEle1.Rows[i].Cells[j].Value = "";
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fromFloor > NowIsAt)
            {
                loadGridview();
                fromFloor -= 1;
                ele1.CurrentFloor = fromFloor;
                
            }
            else if(fromFloor < NowIsAt){
                loadGridview();
                fromFloor += 1;
                ele1.CurrentFloor = fromFloor;
            }
            else {
                ele1.CurrentFloor = fromFloor;
                loadGridview();
                timer1.Stop();
                fromFloor = 0;
                ele1.DoorStatus = true;
                OpenDoor();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (fromFloor > NowIsAt)
            {
                loadGridview();
                fromFloor -= 1;
                ele2.CurrentFloor = fromFloor;                
            }
            else if (fromFloor < NowIsAt)
            {
                loadGridview();
                fromFloor += 1;
                ele2.CurrentFloor = fromFloor;
            }
            else
            {
                ele2.CurrentFloor = fromFloor;
                loadGridview();
                timer2.Stop();
                fromFloor = 0;
                ele2.DoorStatus = true;
                OpenDoor();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (fromFloor > NowIsAt)
            {                
                loadGridview();
                fromFloor -= 1;
                ele3.CurrentFloor = fromFloor;
            }
            else if (fromFloor < NowIsAt)
            {
                loadGridview();
                fromFloor += 1;
                ele3.CurrentFloor = fromFloor;
            }
            else
            {
                ele3.CurrentFloor = fromFloor;
                loadGridview();
                timer3.Stop();
                fromFloor = 0;
                ele3.DoorStatus = true;                
                OpenDoor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbNowAt.Enabled = false;
            gboxInside.Enabled = false;
        }

        private void cbGoTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GotoFloor = Int32.Parse(cbGoTo.SelectedItem.ToString());
            MoveTo(noruElevator, GotoFloor);
            gboxInside.Visible = false;
        }
        public void MoveTo(Elevator elevator, int floor)
        {
            if (elevator == ele1)
            {
                lblEle1DoorStatus.Text = (ele1.DoorStatus = false).ToString();
                txtMainLog.Text += ">> エレベーター I が " + floor.ToString() + " 階へ向かって来ます...\r\n";
                timer4.Start();
            }else if(elevator == ele2)
            {
                lblEle2DoorStatus.Text = (ele2.DoorStatus = false).ToString();
                txtMainLog.Text += ">> エレベーター II が " + floor.ToString() + "階へ向かって来ます...\r\n";
                timer5.Start();
            }else if(elevator == ele3)
            {
                lblEle3DoorStatus.Text = (ele3.DoorStatus = false).ToString();
                txtMainLog.Text += ">> エレベーター III が " + floor.ToString() + "階へ向かって来ます...\r\n";
                timer6.Start();
            }
            //elevator.CurrentFloor = floor;
            //elevator.DoorStatus = false;
            //loadGridview();
            //txtMainLog.Text += ">> Elevator Going to " + floor+ "...\r\n";
            LoadLabel();            
        }
        public void LoadLabel()
        {
            lblEle1CurrentFloor.Text = ele1.CurrentFloor.ToString();
            lblEle2CurrentFloor.Text = ele2.CurrentFloor.ToString();
            lblEle3CurrentFloor.Text = ele3.CurrentFloor.ToString();
            lblEle1DoorStatus.Text = ele1.DoorStatus.ToString();
            lblEle2DoorStatus.Text = ele2.DoorStatus.ToString();
            lblEle3DoorStatus.Text = ele3.DoorStatus.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (ele1.CurrentFloor > GotoFloor)
            {
                loadGridview();
                ele1.CurrentFloor -= 1;
                

            }
            else if (ele1.CurrentFloor < GotoFloor)
            {
                loadGridview();
                ele1.CurrentFloor += 1;
            }
            else
            {
                ele1.CurrentFloor = GotoFloor;
                loadGridview();
                timer4.Stop();
                GotoFloor = 0;
                ele1.DoorStatus = true;
                OpenDoor();
                gboxInside.Visible = false;
            }
        }

        private void dtgvEle1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            LoadLabel();
        }

        private void btCallElevator_Validating(object sender, CancelEventArgs e)
        {
            if (cmbNowIsAt.Text == "--0--")
            {
                MessageBox.Show("Please select floor!!");
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (ele2.CurrentFloor > GotoFloor)
            {
                loadGridview();
                ele2.CurrentFloor -= 1;


            }
            else if (ele2.CurrentFloor < GotoFloor)
            {
                loadGridview();
                ele2.CurrentFloor += 1;
            }
            else
            {
                ele2.CurrentFloor = GotoFloor;
                loadGridview();
                timer5.Stop();
                GotoFloor = 0;
                ele2.DoorStatus = true;
                OpenDoor();
                gboxInside.Visible = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (ele3.CurrentFloor > GotoFloor)
            {
                loadGridview();
                ele3.CurrentFloor -= 1;


            }
            else if (ele3.CurrentFloor < GotoFloor)
            {
                loadGridview();
                ele3.CurrentFloor += 1;
            }
            else
            {
                ele3.CurrentFloor = GotoFloor;
                loadGridview();
                timer6.Stop();
                GotoFloor = 0;
                ele3.DoorStatus = true;
                OpenDoor();
                gboxInside.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random r = new System.Random();
            ele1.CurrentFloor = r.Next(10) + 1;
            ele2.CurrentFloor = r.Next(10) + 1;
            ele3.CurrentFloor = r.Next(10) + 1;
            loadGridview();
            gbNowAt.Enabled = true;
            gboxInside.Enabled = true;
            dtgvEle1.Enabled = true;
        }
    }
}
