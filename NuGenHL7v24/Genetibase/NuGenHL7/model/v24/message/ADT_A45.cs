using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a ADT_A45 message structure (see chapter 3). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: EVN (Event Type) <b></b><br>
	/// 2: PID (Patient identification) <b></b><br>
	/// 3: PD1 (patient additional demographic) <b>optional </b><br>
	/// 4: ADT_A45_MERGE_INFO (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ADT_A45:AbstractMessage
	{
		/// <summary> Returns MSH (Message Header) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns EVN (Event Type) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PID (Patient identification) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PD1 (patient additional demographic) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ADT_A45_MERGE_INFO </summary>
		virtual public int MERGE_INFOReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("MERGE_INFO").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ADT_A45 Group with custom ModelClassFactory.</summary>
		public ADT_A45(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A45 Group with DefaultModelClassFactory. </summary>
		public ADT_A45():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(ADT_A45_MERGE_INFO), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ADT_A45_MERGE_INFO (a Group object) - creates it if necessary</summary>
		public virtual ADT_A45_MERGE_INFO getMERGE_INFO()
		{
			ADT_A45_MERGE_INFO ret = null;
			try
			{
				ret = (ADT_A45_MERGE_INFO) this.get_Renamed("MERGE_INFO");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADT_A45_MERGE_INFO
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADT_A45_MERGE_INFO getMERGE_INFO(int rep)
		{
			return (ADT_A45_MERGE_INFO) this.get_Renamed("MERGE_INFO", rep);
		}
	}
}