﻿using ILG_Global.BackEnd.BussinessLogic.Abstraction.Repositories;
using ILG_Global.BackEnd.BussinessLogic.Abstraction.Services;
using ILG_Global.BackEnd.BussinessLogic.Models;
using ILG_Global.BackEnd.BussinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILG_Global.BackEnd.Web.Services
{
    public class SectionMasterService : ISectionMasterService
    {
        private readonly ISectionMasterRepository oSectionMasterRepository;

        public SectionMasterService(ISectionMasterRepository oSectionMasterRepository)
        {
            this.oSectionMasterRepository = oSectionMasterRepository;
        }


        public async Task<bool> DeleteByID(int nEntityID)
        {
            try
            {
                await oSectionMasterRepository.DeleteById(nEntityID);
                
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public async Task<bool> Insert(SectionMasterViewModel oEntity)
        {
            try
            {
                SectionMaster oSectionMaster = oConvertToDataModel(oEntity);

                await oSectionMasterRepository.Insert(oSectionMaster);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        
        public async Task<List<SectionMasterViewModel>> SelectAllAsync()
        {
            IEnumerable<SectionMaster> lSectionsMasters  =  await oSectionMasterRepository.SelectAll();
            List<SectionMasterViewModel> lSectionMasterViewModels =   lConvertToVMs(lSectionsMasters);
            return lSectionMasterViewModels;
        }

        public async Task<SectionMasterViewModel> SelectByIdAsync(int nID)
        {
            SectionMaster oSectionMaster = await oSectionMasterRepository.SelectById(nID);
            SectionMasterViewModel oSectionMasterViewModel= oConvertToVM(oSectionMaster);
            return (oSectionMasterViewModel);
        }

        public async Task<bool> Update(SectionMasterViewModel oEntity)
        {
            try
            {
                SectionMaster oSectionMaster = oConvertToDataModel(oEntity);
                await oSectionMasterRepository.UpdateById(oSectionMaster);
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public List<SectionMasterViewModel> lConvertToVMs(IEnumerable<SectionMaster> lSectionsMasters)
        {
            List<SectionMasterViewModel> lSectionMasterViewModels = new List<SectionMasterViewModel>() ;

            foreach (SectionMaster oSectionMaster in lSectionsMasters)
            {
                SectionMasterViewModel oSectionMasterViewModel =  oConvertToVM(oSectionMaster);
                lSectionMasterViewModels.Add(oSectionMasterViewModel);
            }
            return lSectionMasterViewModels;
        }

        public SectionMaster oConvertToDataModel(SectionMasterViewModel oSectionMasterVM)
        {
            SectionMaster oSectionMaster = new SectionMaster
            {
                ID = oSectionMasterVM.ID,
                IsEnabled = oSectionMasterVM.IsEnabled,
            };
            return oSectionMaster;
        }

        public SectionMasterViewModel oConvertToVM(SectionMaster oSectionMaster)
        {
            SectionMasterViewModel oSectionMasterVM = new SectionMasterViewModel
            {
                ID = oSectionMaster.ID,
                IsEnabled = oSectionMaster.IsEnabled,
            };
            return oSectionMasterVM;
        }

    }
}
