using DAL.Entities;
using DAL.EntityFramework;
using Model;
using Model.GridModels;
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

        #region clients
        private List<ClientsGridModel> _clientsGridData;
        private void LoadClientsGrid()
        {
            //load data
            _clientsGridData = _dbContext.Clients
                .Select(e => new ClientsGridModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    SecondName = e.SecondName,
                    PassportNumber = e.PassportNumber,
                    DateOfBirth = e.DateOfBirth
                })
                .ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = _clientsGridData };

            //setup columns
            dataGridView1.Columns.Clear();
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "IdColumn",
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Name",
                    DataPropertyName = "Name",
                    HeaderText = "Имя",
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "SecondName",
                    DataPropertyName ="SecondName",
                    HeaderText = "Фамилия"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell()
                    {
                        Style = new DataGridViewCellStyle(){ Format = "dd/MM/yyyy" }
                    })
                {
                    Name = "DateOfBirth",
                    DataPropertyName ="DateOfBirth",
                    HeaderText = "Дата рождения",

                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="PassportNumber",
                    DataPropertyName ="PassportNumber",
                    HeaderText = "Номер паспорта"
                }
            };
            foreach (var item in columns)
            {
                dataGridView1.Columns.Add(item);
            }

            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToDeleteRows = _userRights.ClientsRights.CanDelete;
            dataGridView1.AllowUserToAddRows = _userRights.ClientsRights.CanAdd;
        }
        private void UpdateClientsGrid()
        {

        }
        private void RefreshClientsGrid()
        {

        }
        #endregion


        private void LoadRoomsGrid()
        {
            var roomsGridData = _dbContext.Rooms.Select(e =>
            new
            {
                e.Id,
                e.Number,
                Name = e.RoomType.Name,
                e.RoomType.Cost,
                Capacity = e.Capacity

            }).ToArray();
            dataGridView2.DataSource = new BindingSource { DataSource = roomsGridData };

            //setup columns
            dataGridView2.Columns.Clear();
            foreach (var item in roomsGridData)
            {
                dataGridView2.Rows.Add(
                    item.Id,
                    item.Number,
                    item.Name,
                    item.Cost,
                    item.Capacity

                );
            }
            //add columns
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Id",
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Number",
                    DataPropertyName = "Nunmer",
                    HeaderText = "Номер комнаты"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="RoomType",
                    DataPropertyName = "Name",
                    HeaderText = "Тип комнаты"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Price",
                    DataPropertyName = "Cost",
                    HeaderText = "Стоимость за сутки"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Capacity",
                    DataPropertyName = "Capacity",
                    HeaderText = "Вместимость"
                }
            };
            foreach (var item in columns)
            {
                dataGridView2.Columns.Add(item);
            }
            dataGridView2.AllowUserToDeleteRows = this._userRights.RoomsRights.CanDelete;
            dataGridView2.AllowUserToAddRows = this._userRights.RoomsRights.CanAdd;

        }

        private void LoadEmployeesGrid()
        {

            var employeesGridData = _dbContext.Employees.Select(e =>
           new
           {
               e.Id,
               e.Name,
               e.SecondName,
               e.Position,
               e.NumberPhone

           }).ToArray();
            dataGridView3.DataSource = new BindingSource { DataSource = employeesGridData };

            //setup columns
            dataGridView3.Columns.Clear();
            foreach (var item in employeesGridData)
            {
                dataGridView3.Rows.Add(
                    item.Id,
                    item.Name,
                    item.SecondName,
                    item.Position,
                    item.NumberPhone

                );
            }
            //add columns
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Id",
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Name",
                    DataPropertyName = "Name",
                    HeaderText = "Имя"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="SecondName",
                     DataPropertyName = "SecondName",
                    HeaderText = "Фамилия"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Position",
                    DataPropertyName = "Position",
                    HeaderText = "Должность"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="NumberPhone",
                    DataPropertyName = "NumberPhone",
                    HeaderText = "Номер телефона"
                }
            };
            foreach (var item in columns)
            {
                dataGridView3.Columns.Add(item);
            }


           
            dataGridView3.AllowUserToDeleteRows = this._userRights.EmployeesRights.CanDelete;
            dataGridView3.AllowUserToAddRows = this._userRights.EmployeesRights.CanAdd;

        }

        private void LoadPaymentGrid()
        {
            var paymentsGridData = _dbContext.Payments.Select(e =>
            new
            {
                e.Id,
                e.Client.Name,
                e.Client.SecondName,
                e.ArrivalDate,
                e.DepartureDate,
                e.PeopleCount,
                e.Room.Number,
                e.Room.RoomType.Cost,
                e.ReceiptOfPayment,
                EmployeeName = e.Employee.SecondName,


            }).ToArray();

            dataGridView4.DataSource = new BindingSource { DataSource = paymentsGridData };

            //setup columns
            dataGridView4.Columns.Clear();
            foreach (var item in paymentsGridData)
            {
                dataGridView4.Rows.Add(
                    item.Id,
                    item.Name,
                    item.SecondName,
                    item.ArrivalDate,
                    item.DepartureDate,
                    item.PeopleCount,
                    item.Number,
                    item.Cost,
                    item.ReceiptOfPayment,
                    item.EmployeeName
                );
            }

            //add columns
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Id",
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="Name",
                    DataPropertyName = "Name",
                    HeaderText = "Имя"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="SecondName",
                    DataPropertyName = "SecondName",
                    HeaderText = "Фамилия"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                Name = "ArrivalDate",
                DataPropertyName = "ArrivalDate",
                HeaderText = "Дата въезда"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "DapartureDate",
                    DataPropertyName = "DepartureDate",
                    HeaderText = "Дата выезда"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Capacity",
                    DataPropertyName = "PeopleCount",
                    HeaderText = "Количество человек"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Number",
                    DataPropertyName = "Number",
                    HeaderText = "Номер комнаты"
                },
                 new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Cost",
                    DataPropertyName = "Cost",
                    HeaderText = "Стоимость номера"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "ReceiptOfPayment",
                    DataPropertyName = "ReceiptOfPayment",
                    HeaderText = "Оплата"
                },
                  new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "EmployeeSecondName",
                    DataPropertyName = "EmployeeName",
                    HeaderText = "Сотрудник оформивший"
                }

            };
            foreach (var item in columns)
            {
                dataGridView4.Columns.Add(item);
            }


            
         dataGridView4.AllowUserToDeleteRows = this._userRights.PaymentsRigths.CanDelete;
         dataGridView4.AllowUserToAddRows = this._userRights.PaymentsRigths.CanAdd;

        }
        private void MainForm_Load(object sender, EventArgs eventArgs)
        {
            LoadClientsGrid();
            LoadRoomsGrid();
            LoadEmployeesGrid();
            LoadPaymentGrid();
            //new DataGridViewColumn(new DataGridViewTextBoxCell())
            //{
            //   
        }
    }
}
