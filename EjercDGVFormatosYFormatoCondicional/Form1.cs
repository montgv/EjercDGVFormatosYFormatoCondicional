using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercDGVFormatosYFormatoCondicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            introduccionDatos(6);

            estilos estilo = new estilos(this.dgv);

            estilo.definirFilas("#A34896", "#AFF099", "#6BA358", "------------");
            estilo.definirCabecera("#CDFFBD", "#6BA358");
            estilo.definirFilasAlternas("#CDFFBD", "#F17EE1", "************");
        }

        private void introduccionDatos(int numDatos)
        {
            for (int i = 0; i < numDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);

                fila.Cells[0].Value = i;
                fila.Cells[1].Value = "Montse";
                fila.Cells[2].Value = "Garrido";
                fila.Cells[3].Value = "Valero";
                fila.Cells[4].Value = "Baeza";
                fila.Cells[5].Value = "15/08/1989";
                fila.Cells[6].Value = "A";
                fila.Cells[7].Value = 900;

                dgv.Rows.Add(fila);
            }

            this.dgv.Columns[0].ValueType = Type.GetType("System.Integer");
            this.dgv.Columns[1].ValueType = Type.GetType("System.String");
            this.dgv.Columns[2].ValueType = Type.GetType("System.String");
            this.dgv.Columns[3].ValueType = Type.GetType("System.String");
            this.dgv.Columns[4].ValueType = Type.GetType("System.String");
            this.dgv.Columns[5].ValueType = Type.GetType("System.DateTime");
            this.dgv.Columns[6].ValueType = Type.GetType("System.Char");
            this.dgv.Columns[7].ValueType = Type.GetType("System.Double");
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewCell celda in this.dgv.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.Purple;
                    celda.Style.ForeColor = Color.White;
                    celda.Style.Font = new Font("Comic Sans MS", 12, FontStyle.Italic);
                    celda.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    switch (celda.OwningColumn.Name)
                    {
                        case "columnSumaTotal":
                            celda.Style.Format = "#,#00";
                            break;
                        case "columnFechaAlta":
                            celda.Style.Format = "ddd-MMMM-yyyy";
                            break;
                    }
                }
            }
        }

        private void dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    foreach (DataGridViewCell celda in this.dgv.Rows[e.RowIndex].Cells)
                    {
                        celda.Style = this.dgv.DefaultCellStyle;
                    }
                } else
                {
                    foreach (DataGridViewCell celda in this.dgv.Rows[e.RowIndex].Cells)
                    {
                        celda.Style = this.dgv.AlternatingRowsDefaultCellStyle;
                    }
                }

                
            }
        }
    }
}
