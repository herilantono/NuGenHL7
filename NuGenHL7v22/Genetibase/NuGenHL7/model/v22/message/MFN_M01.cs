using System;
using Genetibase.NuGenHL7.model.v22.group;
using Genetibase.NuGenHL7.model.v22.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v22.message
{
	
	/// <summary> <p>Represents a MFN_M01 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: MFI (MASTER FILE IDENTIFICATION) <b></b><br>
	/// 2: MFN_M01_MF (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M01:AbstractMessage
	{
		/// <summary> Returns MSH (MESSAGE HEADER) - creates it if necessary</summary>
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
		/// <summary> Returns MFI (MASTER FILE IDENTIFICATION) - creates it if necessary</summary>
		virtual public MFI MFI
		{
			get
			{
				MFI ret = null;
				try
				{
					ret = (MFI) this.get_Renamed("MFI");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of MFN_M01_MF </summary>
		virtual public int MFReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("MF").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFN_M01 Group with custom ModelClassFactory.</summary>
		public MFN_M01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new MFN_M01 Group with DefaultModelClassFactory. </summary>
		public MFN_M01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MFI), true, false);
				this.add(typeof(MFN_M01_MF), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of MFN_M01_MF (a Group object) - creates it if necessary</summary>
		public virtual MFN_M01_MF getMF()
		{
			MFN_M01_MF ret = null;
			try
			{
				ret = (MFN_M01_MF) this.get_Renamed("MF");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of MFN_M01_MF
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual MFN_M01_MF getMF(int rep)
		{
			return (MFN_M01_MF) this.get_Renamed("MF", rep);
		}
	}
}