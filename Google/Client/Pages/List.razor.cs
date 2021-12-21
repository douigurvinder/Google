using Google.Client.Contracts;
using Google.Client.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Client.Pages
{
    public partial class List
    {


        [Inject]
        public IGoogleService _PocService { get; set; }
        public List<VW_Individual> Individuals { get; set; } = new List<VW_Individual>();

        public List<Countrie> Countries { get; set; } = new List<Countrie>();
        protected async override Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();

            await loadData();
        }

        private async Task loadData()
        {
            Countries = (await _PocService.GetAllCountries()).ToList();

            Individuals = (await _PocService.GetAllIndividualVW(new GoogleSearch())).ToList();
        }



    }
}
