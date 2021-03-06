using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v21.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v21.group
{
	/// <summary> <p>Represents the ORU_R03_OBSERVATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OBX (RESULT) <b>optional </b><br>
	/// 1: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORU_R03_OBSERVATION:AbstractGroup
	{
		/// <summary> Returns OBX (RESULT) - creates it if necessary</summary>
		virtual public OBX OBX
		{
			get
			{
				OBX ret = null;
				try
				{
					ret = (OBX) this.get_Renamed("OBX");
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
		
		/// <summary> Creates a new ORU_R03_OBSERVATION Group.</summary>
		public ORU_R03_OBSERVATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OBX), false, false);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary</summary>
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
		/// (NOTES AND COMMENTS) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
	}
}