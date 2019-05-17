﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_51172
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Участи сети.
    /// </summary>
    // *** Start programmer edit section *** (SectionNets CustomAttributes)

    // *** End programmer edit section *** (SectionNets CustomAttributes)
    [BusinessServer("IIS.Product_51172.BSForSectionNets, Product_51172.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [Caption("Участи сети")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("SectionNetsE", new string[] {
            "NameSectionNet as \'Название участка сети\'",
            "NumerSectionNet as \'Номер участка сети\'",
            "TypesOfInsulation as \'Тип изоляции\'",
            "TypesOfInsulation.NameTypesOfInsulation as \'Тип изоляции\'",
            "TypeSectionNet as \'Тип прокладки сети\'",
            "ObjectsHeat as \'Объект теплопотребления\'",
            "ObjectsHeat.NameObjectsHeat",
            "StrOtherInformations as \'Информация\'"}, Hidden=new string[] {
            "TypesOfInsulation.NameTypesOfInsulation",
            "ObjectsHeat.NameObjectsHeat"})]
    [MasterViewDefineAttribute("SectionNetsE", "TypesOfInsulation", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "NameTypesOfInsulation")]
    [MasterViewDefineAttribute("SectionNetsE", "ObjectsHeat", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "NameObjectsHeat")]
    [View("SectionNetsL", new string[] {
            "NameSectionNet as \'Название участка сети\'",
            "NumerSectionNet as \'Номер участка сети\'",
            "TypesOfInsulation.NameTypesOfInsulation as \'Тип изоляции\'",
            "TypeSectionNet as \'Тип прокладки сети\'",
            "ObjectsHeat.NameObjectsHeat as \'Объект теплопотребления\'",
            "StrOtherInformations as \'Информация\'"})]
    public class SectionNets : ICSSoft.STORMNET.DataObject
    {
        
        private string fNameSectionNet;
        
        private int fNumerSectionNet;
        
        private IIS.Product_51172.TypesSectionNet fTypeSectionNet;
        
        private IIS.Product_51172.TypesOfInsulation fTypesOfInsulation;
        
        private IIS.Product_51172.ObjectsHeat fObjectsHeat;
        
        // *** Start programmer edit section *** (SectionNets CustomMembers)
        /// <summary>
        /// CheckUnNumer - метод проверки уникальности номера участка сети.
        /// Возврат true - номер уникальный, false - номер НЕ уникальный.
        /// NumerSN - номер введенный пользователем.
        /// NameSN - имя/имена участков у которого(-ых) записан данный проверяемый номер.
        /// </summary>
        public static bool CheckUnNumer(int NumerSN, ref string NameSN)
        {
            var ldef = SQLWhereLanguageDef.LanguageDef;
            ICSSoft.STORMNET.Business.LoadingCustomizationStruct lcs = ICSSoft.STORMNET.Business.LoadingCustomizationStruct.GetSimpleStruct(typeof(SectionNets), "SectionNetsE");
            lcs.LimitFunction = ldef.GetFunction(ldef.funcSQL, "NumerSectionNet= \'{0}\'", NumerSN.ToString());
            ICSSoft.STORMNET.DataObject[] objs = ICSSoft.STORMNET.Business.DataServiceProvider.DataService.LoadObjects(lcs);
            if (objs.Length > 0)
            {
                foreach (SectionNets el in objs)
                    NameSN += $" {el.NameSectionNet}";
                return false;
            }
            return true;
        }
        // *** End programmer edit section *** (SectionNets CustomMembers)

        
        /// <summary>
        /// NameSectionNet.
        /// </summary>
        // *** Start programmer edit section *** (SectionNets.NameSectionNet CustomAttributes)

        // *** End programmer edit section *** (SectionNets.NameSectionNet CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string NameSectionNet
        {
            get
            {
                // *** Start programmer edit section *** (SectionNets.NameSectionNet Get start)

                // *** End programmer edit section *** (SectionNets.NameSectionNet Get start)
                string result = this.fNameSectionNet;
                // *** Start programmer edit section *** (SectionNets.NameSectionNet Get end)

                // *** End programmer edit section *** (SectionNets.NameSectionNet Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SectionNets.NameSectionNet Set start)

                // *** End programmer edit section *** (SectionNets.NameSectionNet Set start)
                this.fNameSectionNet = value;
                // *** Start programmer edit section *** (SectionNets.NameSectionNet Set end)

                // *** End programmer edit section *** (SectionNets.NameSectionNet Set end)
            }
        }
        
        /// <summary>
        /// NumerSectionNet.
        /// </summary>
        // *** Start programmer edit section *** (SectionNets.NumerSectionNet CustomAttributes)

        // *** End programmer edit section *** (SectionNets.NumerSectionNet CustomAttributes)
        [NotNull()]
        public virtual int NumerSectionNet
        {
            get
            {
                // *** Start programmer edit section *** (SectionNets.NumerSectionNet Get start)

                // *** End programmer edit section *** (SectionNets.NumerSectionNet Get start)
                int result = this.fNumerSectionNet;
                // *** Start programmer edit section *** (SectionNets.NumerSectionNet Get end)

                // *** End programmer edit section *** (SectionNets.NumerSectionNet Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SectionNets.NumerSectionNet Set start)

                // *** End programmer edit section *** (SectionNets.NumerSectionNet Set start)
                this.fNumerSectionNet = value;
                // *** Start programmer edit section *** (SectionNets.NumerSectionNet Set end)

                // *** End programmer edit section *** (SectionNets.NumerSectionNet Set end)
            }
        }
        
        /// <summary>
        /// TypeSectionNet.
        /// </summary>
        // *** Start programmer edit section *** (SectionNets.TypeSectionNet CustomAttributes)

        // *** End programmer edit section *** (SectionNets.TypeSectionNet CustomAttributes)
        [NotNull()]
        public virtual IIS.Product_51172.TypesSectionNet TypeSectionNet
        {
            get
            {
                // *** Start programmer edit section *** (SectionNets.TypeSectionNet Get start)

                // *** End programmer edit section *** (SectionNets.TypeSectionNet Get start)
                IIS.Product_51172.TypesSectionNet result = this.fTypeSectionNet;
                // *** Start programmer edit section *** (SectionNets.TypeSectionNet Get end)

                // *** End programmer edit section *** (SectionNets.TypeSectionNet Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SectionNets.TypeSectionNet Set start)

                // *** End programmer edit section *** (SectionNets.TypeSectionNet Set start)
                this.fTypeSectionNet = value;
                // *** Start programmer edit section *** (SectionNets.TypeSectionNet Set end)

                // *** End programmer edit section *** (SectionNets.TypeSectionNet Set end)
            }
        }
        
        /// <summary>
        /// StrOtherInformations.
        /// </summary>
        // *** Start programmer edit section *** (SectionNets.StrOtherInformations CustomAttributes)

        // *** End programmer edit section *** (SectionNets.StrOtherInformations CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        public virtual string StrOtherInformations
        {
            get
            {
                // *** Start programmer edit section *** (SectionNets.StrOtherInformations Get)
                var PKthis = this.__PrimaryKey.ToString();
                var ds = (SQLDataService)DataServiceProvider.DataService;
                var oh = new ObjectsHeat();
                var b = new Buildings();
                var toi = new TypesOfInsulation();
                oh.SetExistObjectPrimaryKey(this.ObjectsHeat.__PrimaryKey.ToString());
                ds.LoadObject(oh);
                b.SetExistObjectPrimaryKey(oh.Buildings.__PrimaryKey.ToString());
                ds.LoadObject(b);
                toi.SetExistObjectPrimaryKey(this.TypesOfInsulation.__PrimaryKey.ToString());
                ds.LoadObject(toi);
                var ret = "Адрес здания: " + b.NameBuildings +
                    ", объект: " + oh.NameObjectsHeat +
                    ", номер участка:" + this.NumerSectionNet.ToString() +
                    ", тип изоляции: " + toi.NameTypesOfInsulation;

                return ret;
                // *** End programmer edit section *** (SectionNets.StrOtherInformations Get)
            }
            set
            {
                // *** Start programmer edit section *** (SectionNets.StrOtherInformations Set)
                
                // *** End programmer edit section *** (SectionNets.StrOtherInformations Set)
            }
        }
        
        /// <summary>
        /// Участи сети.
        /// </summary>
        // *** Start programmer edit section *** (SectionNets.TypesOfInsulation CustomAttributes)

        // *** End programmer edit section *** (SectionNets.TypesOfInsulation CustomAttributes)
        [PropertyStorage(new string[] {
                "TypesOfInsulation"})]
        [NotNull()]
        public virtual IIS.Product_51172.TypesOfInsulation TypesOfInsulation
        {
            get
            {
                // *** Start programmer edit section *** (SectionNets.TypesOfInsulation Get start)

                // *** End programmer edit section *** (SectionNets.TypesOfInsulation Get start)
                IIS.Product_51172.TypesOfInsulation result = this.fTypesOfInsulation;
                // *** Start programmer edit section *** (SectionNets.TypesOfInsulation Get end)

                // *** End programmer edit section *** (SectionNets.TypesOfInsulation Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SectionNets.TypesOfInsulation Set start)

                // *** End programmer edit section *** (SectionNets.TypesOfInsulation Set start)
                this.fTypesOfInsulation = value;
                // *** Start programmer edit section *** (SectionNets.TypesOfInsulation Set end)

                // *** End programmer edit section *** (SectionNets.TypesOfInsulation Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Product_51172.ObjectsHeat.
        /// </summary>
        // *** Start programmer edit section *** (SectionNets.ObjectsHeat CustomAttributes)

        // *** End programmer edit section *** (SectionNets.ObjectsHeat CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ObjectsHeat"})]
        public virtual IIS.Product_51172.ObjectsHeat ObjectsHeat
        {
            get
            {
                // *** Start programmer edit section *** (SectionNets.ObjectsHeat Get start)

                // *** End programmer edit section *** (SectionNets.ObjectsHeat Get start)
                IIS.Product_51172.ObjectsHeat result = this.fObjectsHeat;
                // *** Start programmer edit section *** (SectionNets.ObjectsHeat Get end)

                // *** End programmer edit section *** (SectionNets.ObjectsHeat Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SectionNets.ObjectsHeat Set start)

                // *** End programmer edit section *** (SectionNets.ObjectsHeat Set start)
                this.fObjectsHeat = value;
                // *** Start programmer edit section *** (SectionNets.ObjectsHeat Set end)

                // *** End programmer edit section *** (SectionNets.ObjectsHeat Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "SectionNetsE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SectionNetsE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SectionNetsE", typeof(IIS.Product_51172.SectionNets));
                }
            }
            
            /// <summary>
            /// "SectionNetsL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SectionNetsL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SectionNetsL", typeof(IIS.Product_51172.SectionNets));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of SectionNets.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfSectionNets CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfSectionNets CustomAttributes)
    public class DetailArrayOfSectionNets : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Product_51172.DetailArrayOfSectionNets members)

        // *** End programmer edit section *** (IIS.Product_51172.DetailArrayOfSectionNets members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type SectionNets by index.
        /// </summary>
        /// <summary>
        /// Adds object with type SectionNets.
        /// </summary>
        public DetailArrayOfSectionNets(IIS.Product_51172.ObjectsHeat fObjectsHeat) : 
                base(typeof(SectionNets), ((ICSSoft.STORMNET.DataObject)(fObjectsHeat)))
        {
        }
        
        public IIS.Product_51172.SectionNets this[int index]
        {
            get
            {
                return ((IIS.Product_51172.SectionNets)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Product_51172.SectionNets dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}