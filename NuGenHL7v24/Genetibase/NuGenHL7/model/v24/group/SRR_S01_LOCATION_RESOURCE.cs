using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the SRR_S01_LOCATION_RESOURCE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: AIL (Appointment Information - Location Resource) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRR_S01_LOCATION_RESOURCE:AbstractGroup
	{
		/// <summary> Returns AIL (Appointment Information - Location Resource) - creates it if necessary</summary>
		virtual public AIL AIL
		{
			get
			{
				AIL ret = null;
				try
				{
					ret = (AIL) this.get_Renamed("AIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SRR_S01_LOCATION_RESOURCE Group.</summary>
		public SRR_S01_LOCATION_RESOURCE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(AIL), true, false);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (Notes and Comments) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (Notes and Comments) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
	}
}