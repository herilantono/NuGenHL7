using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RSP_Z88_ALLERGY Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: AL1 (Patient Allergy Information) <b>repeating</b><br>
	/// 1: RSP_Z88_VISIT (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z88_ALLERGY:AbstractGroup
	{
		/// <summary> Returns the number of existing repetitions of AL1 </summary>
		virtual public int AL1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AL1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RSP_Z88_VISIT (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z88_VISIT VISIT
		{
			get
			{
				RSP_Z88_VISIT ret = null;
				try
				{
					ret = (RSP_Z88_VISIT) this.get_Renamed("VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RSP_Z88_ALLERGY Group.</summary>
		public RSP_Z88_ALLERGY(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(AL1), true, true);
				this.add(typeof(RSP_Z88_VISIT), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of AL1 (Patient Allergy Information) - creates it if necessary</summary>
		public virtual AL1 getAL1()
		{
			AL1 ret = null;
			try
			{
				ret = (AL1) this.get_Renamed("AL1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of AL1
		/// (Patient Allergy Information) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AL1 getAL1(int rep)
		{
			return (AL1) this.get_Renamed("AL1", rep);
		}
	}
}