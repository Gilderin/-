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
        private BindingList<ClientsGridModel> _clientsGridData;
        private void LoadClientsGrid()
        {
            //load data
            var clientsGridData = _dbContext.Clients
                .Select(e => new ClientsGridModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    SecondName = e.SecondName,
                    PassportNumber = e.PassportNumber,
                    DateOfBirth = e.DateOfBirth
                })
                .ToList();
            _clientsGridData = new BindingList<ClientsGridModel>(clientsGridData);
            var clientsBindingSource = new BindingSource(_clientsGridData, null);
            clientsDataGridView.DataSource = clientsBindingSource;

            //setup columns
            clientsDataGridView.Columns.Clear();
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
                clientsDataGridView.Columns.Add(item);
            }

            clientsDataGridView.MultiSelect = false;
            clientsDataGridView.AllowUserToDeleteRows = _userRights.ClientsRights.CanDelete;
            clientsDataGridView.AllowUserToAddRows = _userRights.ClientsRights.CanAdd;
        }
        private void UpdateClientsGridDbData()
        {
            var dbData = _dbContext.Clients.ToList();

            //remove deleted from db
            var toRemove = dbData
                .Where(dbClient => !_clientsGridData.Any(e => dbClient.Id == e.Id))
                .ToList();
            _dbContext.Clients.RemoveRange(toRemove);

            //add new clients to db
            var toAdd = _clientsGridData
                .Where(dataGridClient => !dbData.Any(e => dataGridClient.Id == e.Id))
                .Select(e => new Client()
                {
                    Name = e.Name,
                    SecondName = e.SecondName,
                    PassportNumber = e.PassportNumber,
                    DateOfBirth = e.DateOfBirth
                })
                .ToList();
            _dbContext.Clients.AddRange(toAdd);
            _dbContext.SaveChanges();
        }
        private void RefreshClientsGrid()
        {
            this._clientsGridData.Clear();
            var data = _dbContext.Clients.Select(e => new ClientsGridModel()
            {
                Id = e.Id,
                Name = e.Name,
                SecondName = e.SecondName,
                PassportNumber = e.PassportNumber,
                DateOfBirth = e.DateOfBirth
            })
            .ToList();
            foreach (var item in data)
            {
                this._clientsGridData.Add(item);
            }
        }
        private void clientsUpdateDbButton_Click(object sender, EventArgs e)
        {
            UpdateClientsGridDbData();
        }
        private void clientsRefreshGridButton_Click(object sender, EventArgs e)
        {
            RefreshClientsGrid();
        }
        #endregion

        #region rooms
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
            roomsDataGridView.DataSource = new BindingSource { DataSource = roomsGridData };

            //setup columns
            roomsDataGridView.Columns.Clear();
            //foreach (var item in roomsGridData)
            //{
            //    dataGridView2.Rows.Add(
            //        item.Id,
            //        item.Number,
            //        item.Name,
            //        item.Cost,
            //        item.Capacity

            //    );
            //}
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
                roomsDataGridView.Columns.Add(item);
            }
            roomsDataGridView.AllowUserToDeleteRows = this._userRights.RoomsRights.CanDelete;
            roomsDataGridView.AllowUserToAddRows = this._userRights.RoomsRights.CanAdd;

        }
        #endregion

        #region employees
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
            employeesDataGridView.DataSource = new BindingSource { DataSource = employeesGridData };

            //setup columns
            employeesDataGridView.Columns.Clear();
            //foreach (var item in employeesGridData)
            //{
            //    dataGridView3.Rows.Add(
            //        item.Id,
            //        item.Name,
            //        item.SecondName,
            //        item.Position,
            //        item.NumberPhone

            //    );
            //}
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
                employeesDataGridView.Columns.Add(item);
            }



            employeesDataGridView.AllowUserToDeleteRows = this._userRights.EmployeesRights.CanDelete;
            employeesDataGridView.AllowUserToAddRows = this._userRights.EmployeesRights.CanAdd;

        }
        #endregion

        #region payments
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

            paymentsDataGridView.DataSource = new BindingSource { DataSource = paymentsGridData };

            //setup columns
            paymentsDataGridView.Columns.Clear();
            //foreach (var item in paymentsGridData)
            //{
            //    dataGridView4.Rows.Add(
            //        item.Id,
            //        item.Name,
            //        item.SecondName,
            //        item.ArrivalDate,
            //        item.DepartureDate,
            //        item.PeopleCount,
            //        item.Number,
            //        item.Cost,
            //        item.ReceiptOfPayment,
            //        item.EmployeeName
            //    );
            //}

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
                paymentsDataGridView.Columns.Add(item);
            }



            paymentsDataGridView.AllowUserToDeleteRows = this._userRights.PaymentsRigths.CanDelete;
            paymentsDataGridView.AllowUserToAddRows = this._userRights.PaymentsRigths.CanAdd;

        }
        #endregion


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
