using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RQI_I01_GUARANTOR_INSURANCE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: GT1 (Guarantor) <b>optional repeating</b><br>
	/// 1: RQI_I01_INSURANCE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RQI_I01_GUARANTOR_INSURANCE:AbstractGroup
	{
		/// <summary> Returns the number of existing repetitions of GT1 </summary>
		virtual public int GT1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GT1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RQI_I01_INSURANCE </summary>
		virtual public int INSURANCEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("INSURANCE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RQI_I01_GUARANTOR_INSURANCE Group.</summary>
		public RQI_I01_GUARANTOR_INSURANCE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(GT1), false, true);
				this.add(typeof(RQI_I01_INSURANCE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of GT1 (Guarantor) - creates it if necessary</summary>
		public virtual GT1 getGT1()
		{
			GT1 ret = null;
			try
			{
				ret = (GT1) this.get_Renamed("GT1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of GT1
		/// (Guarantor) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of RQI_I01_INSURANCE (a Group object) - creates it if necessary</summary>
		public virtual RQI_I01_INSURANCE getINSURANCE()
		{
			RQI_I01_INSURANCE ret = null;
			try
			{
				ret = (RQI_I01_INSURANCE) this.get_Renamed("INSURANCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RQI_I01_INSURANCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RQI_I01_INSURANCE getINSURANCE(int rep)
		{
			return (RQI_I01_INSURANCE) this.get_Renamed("INSURANCE", rep);
		}
	}
}