using AutoMapper;
using ProjetModeloDDD.Dommain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DommainToViewModelMapingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDommainMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}