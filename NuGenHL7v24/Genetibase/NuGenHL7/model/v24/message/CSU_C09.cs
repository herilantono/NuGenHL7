using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a CSU_C09 message structure (see chapter 7). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: CSU_C09_PATIENT (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of CSU_C09_PATIENT </summary>
		virtual public int PATIENTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATIENT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09 Group with custom ModelClassFactory.</summary>
		public CSU_C09(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new CSU_C09 Group with DefaultModelClassFactory. </summary>
		public CSU_C09():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(CSU_C09_PATIENT), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSU_C09_PATIENT (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_PATIENT getPATIENT()
		{
			CSU_C09_PATIENT ret = null;
			try
			{
				ret = (CSU_C09_PATIENT) this.get_Renamed("PATIENT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_PATIENT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_PATIENT getPATIENT(int rep)
		{
			return (CSU_C09_PATIENT) this.get_Renamed("PATIENT", rep);
		}
	}
}