using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMinesweeper
{
    public partial class GameScreen : Form
    {
        
        public GameScreen()
        {
            InitializeComponent();
            Buttons();
        }


        public void Buttons()
        {
            int RowCount = 15;
            int ColumnCount = 15;

            int idCounter = 0;
            int uidCounter = 0;
            int ButtonTag = 0;
            int id = Persistence.GeneratedIds[idCounter];

            for (int row = 0; row < RowCount; row++)
            {
                for (int column = 0; column < ColumnCount; column++)
                {
                    Button btn = new Button();

                    btn.Left = column * 22;
                    btn.Top = row * 22;
                    btn.Width = 22;
                    btn.Height = 22;
                    btn.Click += new EventHandler(button_Click);
                    PanelGame.Controls.Add(btn);

                    //geeft elke button een tag en doet buttontag + 1
                    btn.Tag = idCounter;
                    idCounter++;

                }
            }
        }

           /* for (int y = 0; y < RowCount; y++)
            {
                for (int x = 0; x < ColumnCount; x++)
                {

                    Button button = new Button();
                    button.Text = " ";
                    button.Left = ColumnCount * 22;
                    button.Top = RowCount * 22;
                    button.Width = 22;
                    button.Height = 22;
                    button.Click += new EventHandler(button_Click);
                    PanelGame.Controls.Add(button);









                    /* Kies een gegenereerde id uit.
                    int id = Persistence.GeneratedIds[idCounter];

                    // Instantieer een nieuwe kaart.
                    Button btn = new Button();

                    Button btn = new Button();
                    btn.Text = " ";
                    btn.Left = ColumnCount * 22;
                    btn.Top = RowCount * 22;
                    btn.Width = 22;
                    btn.Height = 22;
                    btn.Click += new EventHandler(button_Click);

                    // voegt een button toe en geeft die een tag
                    PanelGame.Controls.Add(btn);
                    btn.Tag = idCounter;

                    idCounter++; uidCounter++;*/

                    /* Voeg de kaart toe aan de cardPanel.
                    cardPanel.Controls.Add(card.control);

                    // Hang een event listener aan de kaart zodat de gebruiker erop kan klikken.
                    card.control.Click += (object sender, EventArgs e) => OnCardClick(sender, e, card);
                    cards.Add(uidCounter, card.control);
                    if (Persistence.history.Count > 0 && Persistence.history.Contains(id))
                    {
                        card.control.Hide();
                    }

                    // Increment de id counters.
                    idCounter++; uidCounter++;
                }






                /*for (int row = 0; row < RowCount; row++)
                {
                    for (int column = 0; column < ColumnCount; column++)
                    {
                        Button button = new Button();
                        button.Text = " ";
                        button.Left = column * 22;
                        button.Top = row * 22;
                        button.Width = 22;
                        button.Height = 22;
                        button.Click += new EventHandler(button_Click);
                        PanelGame.Controls.Add(button);
                    }
                }
            }

        }*/
        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}
