using DAL.EntityFramework;
using Model;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Менеджера_гостиницы
{
    public partial class MainForm : Form
    {

        private UserRightsModel _userRights;
        private ApplicationDbContext _dbContext;

        public MainForm()
        {
            this._userRights = RightsService.GetUserRights();
            this._dbContext = new ApplicationDbContext();
            InitializeComponent();
        }

        private void LoadClientsGrid()
        {
            //add columns
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Id",
                    HeaderText = "Id"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Name",
                    HeaderText = "Имя"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="SecondName",
                    HeaderText = "Фамилия"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="DateOfBirth",
                    HeaderText = "Дата рождения"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="PasportNumber",
                    HeaderText = "Номер паспорта"
                }
            };
            foreach (var item in columns)
            {
                dataGridView1.Columns.Add(item);
            }

            //load data
            var clientGridData = _dbContext.Clients.ToArray();
            foreach (var item in clientGridData)
            {
                dataGridView1.Rows.Add(
                    item.Id, item.Name,
                    item.SecondName,
                    item.DateOfBirth,
                    item.PasportNumber
                );
            }

            dataGridView1.AllowUserToDeleteRows = _userRights.ClientsRights.CanDelete;
            dataGridView1.AllowUserToAddRows = _userRights.ClientsRights.CanAdd;
        }

        
        private void LoadRoomsGrid()
        {
            //add columns
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Id",
                    HeaderText = "Id"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Number",
                    HeaderText = "Номер комнаты"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="RoomType",
                    HeaderText = "Тип комнаты"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Price",
                    HeaderText = "Стоимость за сутки"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Capacity",
                    HeaderText = "Вместимость"
                }
            };
            foreach (var item in columns)
            {
                dataGridView2.Columns.Add(item);
            }


            var roomsGridData = _dbContext.Rooms.Select(e => 
            new
            {
                e.Id,
                e.Number,
                Name = e.RoomType.Name,
                e.RoomType.Cost,
                Capacity = e.Capacity
                
            }).ToArray();
            foreach (var item in roomsGridData )
            {
                dataGridView2.Rows.Add(
                    item.Id,
                    item.Number,
                    item.Name,
                    item.Cost,
                    item.Capacity
                       
                );
            }

            dataGridView2.AllowUserToDeleteRows = this._userRights.RoomsRights.CanDelete;
            dataGridView2.AllowUserToAddRows = this._userRights.RoomsRights.CanAdd;

        }
        private void MainForm_Load(object sender, EventArgs eventArgs)
        {
            LoadClientsGrid();
            LoadRoomsGrid();
            //new DataGridViewColumn(new DataGridViewTextBoxCell())
            //{
            //    Name = "ArrivalDate",
            //    HeaderText = "Дата въезда"
            //},
            //    new DataGridViewColumn(new DataGridViewTextBoxCell())
            //    {
            //        Name = "DapartureDate",
            //        HeaderText = "Дата выезда"
            //    },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell())
            //    {
            //        Name = "Capacity",
            //        HeaderText = "Количество человек"
            //    },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell())
            //    {
            //        Name = "Children",
            //        HeaderText = "Дети есть"
            //    },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell())
            //    {
            //        Name = "Номер комнаты",
            //        HeaderText = "Номер комнаты"
            //    },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell())
            //    {
            //        Name = "Оплата",
            //        HeaderText = "Оплата"
            //    },
            //    new DataGridViewColumn(new DataGridViewTextBoxCell())
            //    {
            //        Name = "Общая стоимость",
            //        HeaderText = "Общая стоимость"
            //    }
        }
    }
}
