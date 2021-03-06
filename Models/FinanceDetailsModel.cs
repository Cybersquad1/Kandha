﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NibsMVC.Models
{
    public class FinanceDetailsModel
    {
    }
    public class ReceiptDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }                
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }
        public string checkno { get; set; }
        public DateTime? checkdate { get; set; }
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }
        
    }
    public class CashReceiptDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }        
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }

    }
    public class PaymentDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }
        public string checkno { get; set; }
        public DateTime? checkdate { get; set; }
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }

    }
    public class CashPaymentDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }        
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }

    }
    public class DebitNoteDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }
        public string checkno { get; set; }
        public DateTime? checkdate { get; set; }
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }

    }
    public class CreditNoteDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }
        public string checkno { get; set; }
        public DateTime? checkdate { get; set; }
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }

    }
    public class ContraDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }
        public int refrenceno { get; set; }

    }
    public class JournalDetailsModel
    {
        public int voucherentryid { get; set; }
        public int voucherno { get; set; }
        public DateTime? voucherdate { get; set; }
        public int ledgerid { get; set; }
        public string ledgername { get; set; }

        public int recordno { get; set; }
        public decimal debitamount { get; set; }
        public string checkno { get; set; }
        public DateTime? checkdate { get; set; }
        public string crdescription { get; set; }
        public decimal creditamount { get; set; }
        public string drdescription { get; set; }
        public int debitledgerid { get; set; }
        public string debitledgername { get; set; }
        public int creditledgerid { get; set; }
        public string creditledgername { get; set; }

    }
}