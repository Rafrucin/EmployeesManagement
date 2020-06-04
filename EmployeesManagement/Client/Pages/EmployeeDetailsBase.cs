﻿
using EmployeesManagement.Server.Services;
using EmployeesManagement.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "2";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        protected string Coordinates { get; set; }

        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX } Y = {e.ClientY}";
        }

        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "d-none";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
    }
}
