using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a ADT_A61 message structure (see chapter 3). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: EVN (Event Type) <b></b><br>
	/// 2: PID (Patient identification) <b></b><br>
	/// 3: PD1 (patient additional demographic) <b>optional </b><br>
	/// 4: PV1 (Patient visit) <b></b><br>
	/// 5: ROL (Role) <b>optional repeating</b><br>
	/// 6: PV2 (Patient visit - additional information) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ADT_A61:AbstractMessage
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
		/// <summary> Returns PV1 (Patient visit) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ROL </summary>
		virtual public int ROLReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ROL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns PV2 (Patient visit - additional information) - creates it if necessary</summary>
		virtual public PV2 PV2
		{
			get
			{
				PV2 ret = null;
				try
				{
					ret = (PV2) this.get_Renamed("PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ADT_A61 Group with custom ModelClassFactory.</summary>
		public ADT_A61(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A61 Group with DefaultModelClassFactory. </summary>
		public ADT_A61():base(new DefaultModelClassFactory())
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
				this.add(typeof(PV1), true, false);
				this.add(typeof(ROL), false, true);
				this.add(typeof(PV2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ROL (Role) - creates it if necessary</summary>
		public virtual ROL getROL()
		{
			ROL ret = null;
			try
			{
				ret = (ROL) this.get_Renamed("ROL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ROL
		/// (Role) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ROL getROL(int rep)
		{
			return (ROL) this.get_Renamed("ROL", rep);
		}
	}
}