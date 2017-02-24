using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Mvvm;
using Reactive.Bindings;

namespace PrismApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public List<Employee> Employees { get; }
        public ReactiveProperty<Employee> SelectedEmployee { get; }
        public MainPageViewModel()
        {
            SelectedEmployee = new ReactiveProperty<Employee>();
            Employees = new List<Employee>
            {
                new Employee {FirstName = "Catherine", LastName = "Gilbert"},
                new Employee {FirstName = "Teresa", LastName = "Ellis"},
                new Employee {FirstName = "Jose", LastName = "Robertson"}
            };
        }
    }
}
