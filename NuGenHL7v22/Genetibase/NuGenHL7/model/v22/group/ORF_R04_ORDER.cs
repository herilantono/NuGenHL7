using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the ORF_R04_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (COMMOM ORDER) <b>optional </b><br>
	/// 1: OBR (OBSERVATION REQUEST) <b></b><br>
	/// 2: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
	/// 3: ORF_R04_OBSERVATION (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORF_R04_ORDER:AbstractGroup
	{
		/// <summary> Returns ORC (COMMOM ORDER) - creates it if necessary</summary>
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
		/// <summary> Returns OBR (OBSERVATION REQUEST) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
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
		/// <summary> Returns the number of existing repetitions of ORF_R04_OBSERVATION </summary>
		virtual public int OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORF_R04_ORDER Group.</summary>
		public ORF_R04_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), false, false);
				this.add(typeof(OBR), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(ORF_R04_OBSERVATION), true, true);
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
		
		/// <summary> Returns  first repetition of ORF_R04_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual ORF_R04_OBSERVATION getOBSERVATION()
		{
			ORF_R04_OBSERVATION ret = null;
			try
			{
				ret = (ORF_R04_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORF_R04_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORF_R04_OBSERVATION getOBSERVATION(int rep)
		{
			return (ORF_R04_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}