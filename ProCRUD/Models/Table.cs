//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Table
    {
        [DisplayName("編號")]
        public int Id { get; set; }
        [DisplayName("帳號")]
        public string Account { get; set; }
        [DisplayName("密碼")]
        public string Password { get; set; }
        [DisplayName("姓名")]
        public string UserName { get; set; }
        [DisplayName("電子郵件")]
        public string Email { get; set; }
        [DisplayName("地址")]
        public string Address { get; set; }
    }
}
