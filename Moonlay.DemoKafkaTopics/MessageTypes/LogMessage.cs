// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.5
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MessageTypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class LogMessage : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse(@"{""type"":""record"",""name"":""LogMessage"",""namespace"":""MessageTypes"",""fields"":[{""name"":""IP"",""type"":""string""},{""name"":""Message"",""type"":""string""},{""name"":""Tags"",""default"":{},""type"":{""type"":""map"",""values"":""string""}},{""name"":""Severity"",""type"":{""type"":""enum"",""name"":""LogLevel"",""namespace"":""MessageTypes"",""symbols"":[""None"",""Verbose"",""Info"",""Warning"",""Error""]}}]}");
		private string _IP;
		private string _Message;
		private IDictionary<string,System.String> _Tags;
		private MessageTypes.LogLevel _Severity;
		public virtual Schema Schema
		{
			get
			{
				return LogMessage._SCHEMA;
			}
		}
		public string IP
		{
			get
			{
				return this._IP;
			}
			set
			{
				this._IP = value;
			}
		}
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				this._Message = value;
			}
		}
		public IDictionary<string,System.String> Tags
		{
			get
			{
				return this._Tags;
			}
			set
			{
				this._Tags = value;
			}
		}
		public MessageTypes.LogLevel Severity
		{
			get
			{
				return this._Severity;
			}
			set
			{
				this._Severity = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.IP;
			case 1: return this.Message;
			case 2: return this.Tags;
			case 3: return this.Severity;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.IP = (System.String)fieldValue; break;
			case 1: this.Message = (System.String)fieldValue; break;
			case 2: this.Tags = (IDictionary<string,System.String>)fieldValue; break;
			case 3: this.Severity = (MessageTypes.LogLevel)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
