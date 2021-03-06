//
// Class	:	BDSupplierBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:05 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class BDSupplierBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SupplierID {get;set;}

		[DataMember]
		public string SupplierCode {get;set;}

		[DataMember]
		public string SupplierName {get;set;}

		[DataMember]
		public string Address {get;set;}

		[DataMember]
		public string Phone1 {get;set;}

		[DataMember]
		public string phone2 {get;set;}

		[DataMember]
		public string Mobile1 {get;set;}

		[DataMember]
		public string Mobile2 {get;set;}

		[DataMember]
		public string Email {get;set;}

		[DataMember]
		public bool? IsActive {get;set;}

		[DataMember]
		public decimal? Debit {get;set;}

		[DataMember]
		public decimal? Credit {get;set;}

		
		#endregion
	}
}
			
