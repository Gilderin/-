using DAL.Entities;
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

        #region clients
        private BindingSource _clientsBindingSource = new BindingSource();
        private void LoadClientsGrid()
        {
            //load data
            var clientGridData = _dbContext.Clients
                .Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.SecondName,
                    e.PasportNumber,
                    e.DateOfBirth
                })
                .ToList();
            _clientsBindingSource.DataSource = clientGridData;
            dataGridView1.DataSource = this._clientsBindingSource;

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
                    Name ="PasportNumber",
                    DataPropertyName ="PasportNumber",
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
        #endregion


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

            dataGridView2.AllowUserToDeleteRows = true;
            dataGridView2.AllowUserToAddRows = true;

        }

        private void LoadEmployeesGrid()
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
                    Name ="Position",
                    HeaderText = "Должность"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name ="NumberPhone",
                    HeaderText = "Номер телефона"
                }
            };
            foreach (var item in columns)
            {
                dataGridView3.Columns.Add(item);
            }


            var employeesGridData = _dbContext.Employees.Select(e =>
            new
            {
                e.Id,
                e.Name,
                e.SecondName,
                e.Position,
                e.NumberPhone

            }).ToArray();
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

            dataGridView2.AllowUserToDeleteRows = this._userRights.EmployeesRights.CanDelete;
            dataGridView2.AllowUserToAddRows = this._userRights.EmployeesRights.CanAdd;

        }

        private void LoadPaymentGrid()
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
                Name = "ArrivalDate",
                HeaderText = "Дата въезда"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "DapartureDate",
                    HeaderText = "Дата выезда"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Capacity",
                    HeaderText = "Количество человек"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Number",
                    HeaderText = "Номер комнаты"
                },
                 new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "Cost",
                    HeaderText = "Стоимость номера"
                },
                new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "ReceiptOfPayment",
                    HeaderText = "Оплата"
                },
                  new DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    Name = "EmployeeSecondName",
                    HeaderText = "Сотрудник оформивший"
                }

            };
            foreach (var item in columns)
            {
                dataGridView4.Columns.Add(item);
            }


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
                EmployeeName= e.Employee.SecondName,


            }).ToArray();
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
