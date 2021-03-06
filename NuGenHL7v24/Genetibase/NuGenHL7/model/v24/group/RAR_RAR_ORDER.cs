using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RAR_RAR_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RAR_RAR_ENCODING (a Group object) <b>optional </b><br>
	/// 2: RXA (Pharmacy/Treatment Administration) <b>repeating</b><br>
	/// 3: RXR (Pharmacy/Treatment Route) <b></b><br>
	/// </summary>
	[Serializable]
	public class RAR_RAR_ORDER:AbstractGroup
	{
		/// <summary> Returns ORC (Common Order) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RAR_RAR_ENCODING (a Group object) - creates it if necessary</summary>
		virtual public RAR_RAR_ENCODING ENCODING
		{
			get
			{
				RAR_RAR_ENCODING ret = null;
				try
				{
					ret = (RAR_RAR_ENCODING) this.get_Renamed("ENCODING");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RXA </summary>
		virtual public int RXAReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXA").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		virtual public RXR RXR
		{
			get
			{
				RXR ret = null;
				try
				{
					ret = (RXR) this.get_Renamed("RXR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RAR_RAR_ORDER Group.</summary>
		public RAR_RAR_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RAR_RAR_ENCODING), false, false);
				this.add(typeof(RXA), true, true);
				this.add(typeof(RXR), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RXA (Pharmacy/Treatment Administration) - creates it if necessary</summary>
		public virtual RXA getRXA()
		{
			RXA ret = null;
			try
			{
				ret = (RXA) this.get_Renamed("RXA");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXA
		/// (Pharmacy/Treatment Administration) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXA getRXA(int rep)
		{
			return (RXA) this.get_Renamed("RXA", rep);
		}
	}
}