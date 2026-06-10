using System.Drawing;
using System.Windows.Forms;

namespace Practice11_12_13_CalculatorLayout;

public class MainForm : Form
{
    public MainForm()
    {
        Text = "Калькулятор";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(320, 420);
        MaximizeBox = false;
        MinimizeBox = false;

        Panel pnlDisplay = new()
        {
            Dock = DockStyle.Top,
            Height = 80,
            Padding = new Padding(10)
        };

        Label lblDisplay = new()
        {
            Name = "lblDisplay",
            Text = "0",
            Dock = DockStyle.Fill,
            BackColor = Color.White,
            TextAlign = ContentAlignment.MiddleRight,
            Font = new Font("Segoe UI", 24, FontStyle.Bold),
            BorderStyle = BorderStyle.FixedSingle
        };
        pnlDisplay.Controls.Add(lblDisplay);

        TableLayoutPanel table = new()
        {
            Dock = DockStyle.Fill,
            ColumnCount = 4,
            RowCount = 5,
            Padding = new Padding(10)
        };

        for (int i = 0; i < 4; i++)
        {
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
        }

        for (int i = 0; i < 5; i++)
        {
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
        }

        string[,] buttons =
        {
            { "7", "8", "9", "/" },
            { "4", "5", "6", "*" },
            { "1", "2", "3", "-" },
            { "0", ".", "=", "+" },
            { "CE", "C", "+/-", "%" }
        };

        for (int row = 0; row < buttons.GetLength(0); row++)
        {
            for (int col = 0; col < buttons.GetLength(1); col++)
            {
                Button button = new()
                {
                    Text = buttons[row, col],
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Margin = new Padding(4)
                };
                table.Controls.Add(button, col, row);
            }
        }

        Controls.Add(table);
        Controls.Add(pnlDisplay);
    }
}
