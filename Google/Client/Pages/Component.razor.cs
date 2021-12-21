using Google.Client.Entities;
using Google.Client.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Client.Pages
{
    public partial class Component
    {



        [Inject]
        public NavigationManager _navigationManager { get; set; }

        [Inject]
        public GoogleService _studentService { get; set; }

        public Individual ObjStudent { get; set; } = new Individual();

        public List<Education> _residenceTypes { get; set; } = new List<Education>();
        public List<Countrie> _modeOfTranspots { get; set; } = new List<Countrie>();


        [Parameter]
        public string StudentGuid { get; set; }

        protected async override Task OnInitializedAsync()
        {

            _residenceTypes = (await _studentService.GetAllEducations()).ToList();
            _modeOfTranspots = (await _studentService.GetAllCountries()).ToList();


            if (!string.IsNullOrEmpty(StudentGuid)) {
                ObjStudent = await _studentService.GetIndividualByGuid(new Guid(StudentGuid));
            }
            // return base.OnInitializedAsync();
        }

        public async Task HandleValidSubmit()
        {
            if (ObjStudent.IndividualID == 0) {
                ObjStudent.CreatedDate = DateTime.Now;
                ObjStudent.IndividualGuid = Guid.NewGuid();

            }
            ObjStudent.ModifiedDate = DateTime.Now;
            await _studentService.Save(ObjStudent);
            _navigationManager.NavigateTo("/");

        }

        public void HandleInvalidSubmit()
        {

        }
        public void OnCancleClick()
        {
            _navigationManager.NavigateTo("/");
        }



    }
}
