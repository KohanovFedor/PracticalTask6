﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_51172
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ClientsL : BaseListForm<Clients>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ClientsL() : base(Clients.Views.ClientsL)
        {
            EditPage = ClientsE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Clients/ClientsL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}