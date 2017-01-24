using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public static int trial;
    public int[] score = { 6, 5, 4, 3, 2 };
    public String[] names = { "a", "b", "c", "d", "e" };
    public String hs = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        scorewriter();
    }
    public void scorewriter()
    {
        for (int i = 0; i < score.Length; i++)
        {
            if (hs == "")
            {
                hs = names[i].ToString() + " - " + score[i].ToString();
            }
            else
            {
                hs += "<br/>" + names[i].ToString() + " - " + score[i].ToString();
            }
        }
    }
    public void button1_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button1);
    }

    public void button2_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button2);
    }

    public void button3_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button3);
    }

    public void button4_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button4);
    }

    public void button5_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button5);
    }

    public void button6_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button6);
    }

    public void button7_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button7);
    }

    public void button8_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button8);
    }

    public void button9_Click(object sender, EventArgs e)
    {
        GenericButtonClick(button9);
    }
   
    public void restartButton_Click(object sender, EventArgs e)
    {
        clearContents();
        
        if(restartButton.Text=="Play Game")
        {
            enableAllButtons();
            restartButton.Text = "Restart";
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            nameTextBox.Visible = false;
            submitButton.Visible = false;
            turnLabel.Visible = true;
            hsLabel.Visible = false;
        }else if (restartButton.Text == "Restart")
        {
            enableAllButtons();
            nameTextBox.Text = "";     
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            nameTextBox.Visible = false;
            submitButton.Visible = false;
            hsLabel.Visible = false;
        }
        button1.BackColor = System.Drawing.Color.White;
        button2.BackColor = System.Drawing.Color.White;
        button3.BackColor = System.Drawing.Color.White;
        button4.BackColor = System.Drawing.Color.White;
        button5.BackColor = System.Drawing.Color.White;
        button6.BackColor = System.Drawing.Color.White;
        button7.BackColor = System.Drawing.Color.White;
        button8.BackColor = System.Drawing.Color.White;
        button9.BackColor = System.Drawing.Color.White;
        int PlayerNumberInt = CurrentPlayer();
        if (PlayerNumberInt == 2)
        {
            ComputerMove();
        }
    }



    private void enableAllButtons()
    {
        button1.Enabled = true;
        button2.Enabled = true;
        button3.Enabled = true;
        button4.Enabled = true;
        button5.Enabled = true;
        button6.Enabled = true;
        button7.Enabled = true;
        button8.Enabled = true;
        button9.Enabled = true;
    }

    private void disableAllButtons()
    {
        button1.Enabled = false;
        button2.Enabled = false;
        button3.Enabled = false;
        button4.Enabled = false;
        button5.Enabled = false;
        button6.Enabled = false;
        button7.Enabled = false;
        button8.Enabled = false;
        button9.Enabled = false;
    }


    private void clearContents()
    {
        button1.Text = "";
        button2.Text = "";
        button3.Text = "";
        button4.Text = "";
        button5.Text = "";
        button6.Text = "";
        button7.Text = "";
        button8.Text = "";
        button9.Text = "";
        MessageLabel.Visible = false;
        hsLabel.Visible = true;
    }

    private void changePlayers()
    {

        if (turnLabel.Text == "Turn: Player One")
        {
            turnLabel.Text = "Turn: Computer";
            ComputerMove();
        }
        else if (turnLabel.Text == "Turn: Computer")
        {
            turnLabel.Text = "Turn: Player One";
        }
    }

    public int CurrentPlayer()
    {
        int PlayerNumberInt = 0;
        string PlayerNumberText = turnLabel.Text.Substring(turnLabel.Text.Length - 3);
        if (PlayerNumberText == "One")
        {
            PlayerNumberInt = 1;
        }
        else
        {
            PlayerNumberInt = 2;
        }
        return PlayerNumberInt;
    }

    
    private void WinnerCheck()
    {
        string WinnerName = "";
        if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") |
            (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") |
            (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") |
            (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") |
            (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") |
            (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") |
            (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") |
            (button7.Text == "X" && button5.Text == "X" && button3.Text == "X"))
        {
            WinnerName = "Player One";
            trial++;
            hsLabel.Text = "Highscores:" + "\n" + hs.ToString();
            hsLabel.Visible = true;
            checkscore();
        }

        if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") |
            (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") |
            (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") |
            (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") |
            (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") |
            (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") |
            (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") |
            (button7.Text == "O" && button5.Text == "O" && button3.Text == "O"))
        {
            WinnerName = "Computer";
        }

        if (WinnerName != "")
        {
            button1.BackColor = System.Drawing.Color.Beige;
            button2.BackColor = System.Drawing.Color.Beige;
            button3.BackColor = System.Drawing.Color.Beige;
            button4.BackColor = System.Drawing.Color.Beige;
            button5.BackColor = System.Drawing.Color.Beige;
            button6.BackColor = System.Drawing.Color.Beige;
            button7.BackColor = System.Drawing.Color.Beige;
            button8.BackColor = System.Drawing.Color.Beige;
            button9.BackColor = System.Drawing.Color.Beige;
            MessageLabel.Text=WinnerName + " Wins! Restart to play again.";
            MessageLabel.Visible = true;
            disableAllButtons();
        }
        else if ((button1.Text != "" && button2.Text != "" && button3.Text != "") &&
            (button4.Text != "" && button5.Text != "" && button6.Text != "") &&
            (button7.Text != "" && button8.Text != "" && button9.Text != ""))
        {
            MessageLabel.Text="It's a tie! Restart to play again.";
            trial++;
            checkscore();
            hsLabel.Text = "Highscores:" + "\n" + hs.ToString();
            hsLabel.Visible = true;
            MessageLabel.Visible = true;
            disableAllButtons();
        }
    }

    public void checkscore()
    {
        if (trial >= score[4])
        {            
            Label1.Visible = true;
            Label2.Visible = true;
            nameTextBox.Visible = true;
            submitButton.Visible = true;
            
          }
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {

        int temp = 0;
        String tempname;
        score[4] = trial;
        if ((nameTextBox.Text != "") && (nameTextBox.Text != null))
        {
            names[4] = nameTextBox.Text;
            Label3.Visible = false;
            for (int i = 0; i < (score.Length - 1); i++)
            {

                if (score[i] > score[i + 1])
                {
                    temp = score[i];
                    score[i] = score[i + 1];
                    score[i + 1] = temp;
                    tempname = names[i];
                    names[i] = names[i + 1];
                    names[i + 1] = tempname;
                }

            }
            hs = "";
            scorewriter();
            hsLabel.Text = "Highscores:"+"\n"+hs.ToString();
            hsLabel.Visible = true;
            Label2.Visible = false;
            nameTextBox.Visible = false;
            submitButton.Visible = false;
        }
        else
        {
            Label3.Visible = true;
        }
    }
    public void writeText()
    {
        string FilePath = HttpContext.Current.Request.PhysicalApplicationPath + "//Scores.txt";
        System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath);
        file.WriteLine(hs.ToString());
        file.Close();
    }
    private void GenericButtonClick(Button thisButton)
    {        
            int PlayerNumberInt = CurrentPlayer();
            if (PlayerNumberInt == 1)
            {
                thisButton.Text = "X";
            }
            else if (PlayerNumberInt == 2)
            {
                thisButton.Text = "O";
            }
            WinnerCheck();
            changePlayers();
        thisButton.Enabled = false;
    }

    private void ComputerMove()
    {
        if (button1.Text == "" && button2.Text == "O" && button3.Text == "O")
        {
            GenericButtonClick(button1);
        }
        else if (button1.Text == "O" && button2.Text == "" && button3.Text == "O")
        {
            GenericButtonClick(button2);
        }
        else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "")
        {
            GenericButtonClick(button3);
        }
        else if (button4.Text == "" && button5.Text == "O" && button6.Text == "O")
        {
            GenericButtonClick(button4);
        }
        else if (button4.Text == "O" && button5.Text == "" && button6.Text == "O")
        {
            GenericButtonClick(button5);
        }
        else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "")
        {
            GenericButtonClick(button6);
        }
        else if (button7.Text == "" && button8.Text == "O" && button9.Text == "O")
        {
            GenericButtonClick(button7);
        }
        else if (button7.Text == "O" && button8.Text == "" && button9.Text == "O")
        {
            GenericButtonClick(button8);
        }
        else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button1.Text == "" && button4.Text == "O" && button7.Text == "O")
        {
            GenericButtonClick(button1);
        }
        else if (button1.Text == "O" && button4.Text == "" && button7.Text == "O")
        {
            GenericButtonClick(button4);
        }
        else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "")
        {
            GenericButtonClick(button7);
        }
        else if (button2.Text == "" && button5.Text == "O" && button8.Text == "O")
        {
            GenericButtonClick(button2);
        }
        else if (button2.Text == "O" && button5.Text == "" && button8.Text == "O")
        {
            GenericButtonClick(button5);
        }
        else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "")
        {
            GenericButtonClick(button8);
        }
        else if (button3.Text == "" && button6.Text == "O" && button9.Text == "O")
        {
            GenericButtonClick(button3);
        }
        else if (button3.Text == "O" && button6.Text == "" && button9.Text == "O")
        {
            GenericButtonClick(button6);
        }
        else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button1.Text == "" && button5.Text == "O" && button9.Text == "O")
        {
            GenericButtonClick(button1);
        }
        else if (button1.Text == "O" && button5.Text == "" && button9.Text == "O")
        {
            GenericButtonClick(button5);
        }
        else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button7.Text == "" && button5.Text == "O" && button3.Text == "O")
        {
            GenericButtonClick(button7);
        }
        else if (button7.Text == "O" && button5.Text == "" && button3.Text == "O")
        {
            GenericButtonClick(button5);
        }
        else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "")
        {
            GenericButtonClick(button3);
        }
        else if (button1.Text == "" && button2.Text == "X" && button3.Text == "X")
        {
            GenericButtonClick(button1);
        }
        else if (button1.Text == "X" && button2.Text == "" && button3.Text == "X")
        {
            GenericButtonClick(button2);
        }
        else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "")
        {
            GenericButtonClick(button3);
        }
        else if (button4.Text == "" && button5.Text == "X" && button6.Text == "X")
        {
            GenericButtonClick(button4);
        }
        else if (button4.Text == "X" && button5.Text == "" && button6.Text == "X")
        {
            GenericButtonClick(button5);
        }
        else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "")
        {
            GenericButtonClick(button6);
        }
        else if (button7.Text == "" && button8.Text == "X" && button9.Text == "X")
        {
            GenericButtonClick(button7);
        }
        else if (button7.Text == "X" && button8.Text == "" && button9.Text == "X")
        {
            GenericButtonClick(button8);
        }
        else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button1.Text == "" && button4.Text == "X" && button7.Text == "X")
        {
            GenericButtonClick(button1);
        }
        else if (button1.Text == "X" && button4.Text == "" && button7.Text == "X")
        {
            GenericButtonClick(button4);
        }
        else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "")
        {
            GenericButtonClick(button7);
        }
        else if (button2.Text == "" && button5.Text == "X" && button8.Text == "X")
        {
            GenericButtonClick(button2);
        }
        else if (button2.Text == "X" && button5.Text == "" && button8.Text == "X")
        {
            GenericButtonClick(button5);
        }
        else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "")
        {
            GenericButtonClick(button8);
        }
        else if (button3.Text == "" && button6.Text == "X" && button9.Text == "X")
        {
            GenericButtonClick(button3);
        }
        else if (button3.Text == "X" && button6.Text == "" && button9.Text == "X")
        {
            GenericButtonClick(button6);
        }
        else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button1.Text == "" && button5.Text == "X" && button9.Text == "X")
        {
            GenericButtonClick(button1);
        }
        else if (button1.Text == "X" && button5.Text == "" && button9.Text == "X")
        {
            GenericButtonClick(button5);
        }
        else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button7.Text == "" && button5.Text == "X" && button3.Text == "X")
        {
            GenericButtonClick(button7);
        }
        else if (button7.Text == "X" && button5.Text == "" && button3.Text == "X")
        {
            GenericButtonClick(button5);
        }
        else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "")
        {
            GenericButtonClick(button3);
        }
        else if (button5.Text == "")
        {
            GenericButtonClick(button5);
        }
        else if (button1.Text == "X" && button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button9.Text == "X" && button1.Text == "")
        {
            GenericButtonClick(button1);
        }
        else if (button7.Text == "X" && button3.Text == "")
        {
            GenericButtonClick(button3);
        }
        else if (button3.Text == "X" && button7.Text == "")
        {
            GenericButtonClick(button7);
        }
        else if (button9.Text == "")
        {
            GenericButtonClick(button9);
        }
        else if (button1.Text == "")
        {
            GenericButtonClick(button1);
        }
        else if (button3.Text == "")
        {
            GenericButtonClick(button3);
        }
        else if (button7.Text == "")
        {
            GenericButtonClick(button7);
        }
        else if (button2.Text == "")
        {
            GenericButtonClick(button2);
        }
        else if (button4.Text == "")
        {
            GenericButtonClick(button4);
        }
        else if (button6.Text == "")
        {
            GenericButtonClick(button6);
        }
        else if (button8.Text == "")
        {
            GenericButtonClick(button8);
        }
    }        
}



  
