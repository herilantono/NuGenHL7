using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a ADT_A02 message structure (see chapter 3.3.2). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: EVN (Event Type) <b></b><br>
	/// 3: PID (Patient Identification) <b></b><br>
	/// 4: PD1 (Patient Additional Demographic) <b>optional </b><br>
	/// 5: ROL (Role) <b>optional repeating</b><br>
	/// 6: PV1 (Patient Visit) <b></b><br>
	/// 7: PV2 (Patient Visit - Additional Information) <b>optional </b><br>
	/// 8: ROL (Role) <b>optional repeating</b><br>
	/// 9: DB1 (Disability) <b>optional repeating</b><br>
	/// 10: OBX (Observation/Result) <b>optional repeating</b><br>
	/// 11: PDA (Patient Death and Autopsy) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ADT_A02:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of SFT </summary>
		virtual public int SFTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SFT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns PID (Patient Identification) - creates it if necessary</summary>
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
		/// <summary> Returns PD1 (Patient Additional Demographic) - creates it if necessary</summary>
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
		/// <summary> Returns PV1 (Patient Visit) - creates it if necessary</summary>
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
		/// <summary> Returns PV2 (Patient Visit - Additional Information) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of ROL2 </summary>
		virtual public int ROL2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ROL2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DB1 </summary>
		virtual public int DB1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DB1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OBX </summary>
		virtual public int OBXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns PDA (Patient Death and Autopsy) - creates it if necessary</summary>
		virtual public PDA PDA
		{
			get
			{
				PDA ret = null;
				try
				{
					ret = (PDA) this.get_Renamed("PDA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ADT_A02 Group with custom ModelClassFactory.</summary>
		public ADT_A02(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A02 Group with DefaultModelClassFactory. </summary>
		public ADT_A02():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SFT), false, true);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(ROL), false, true);
				this.add(typeof(PV1), true, false);
				this.add(typeof(PV2), false, false);
				this.add(typeof(ROL), false, true);
				this.add(typeof(DB1), false, true);
				this.add(typeof(OBX), false, true);
				this.add(typeof(PDA), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SFT (Software Segment) - creates it if necessary</summary>
		public virtual SFT getSFT()
		{
			SFT ret = null;
			try
			{
				ret = (SFT) this.get_Renamed("SFT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SFT
		/// (Software Segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SFT getSFT(int rep)
		{
			return (SFT) this.get_Renamed("SFT", rep);
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
		
		/// <summary> Returns  first repetition of ROL2 (Role) - creates it if necessary</summary>
		public virtual ROL getROL2()
		{
			ROL ret = null;
			try
			{
				ret = (ROL) this.get_Renamed("ROL2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ROL2
		/// (Role) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ROL getROL2(int rep)
		{
			return (ROL) this.get_Renamed("ROL2", rep);
		}
		
		/// <summary> Returns  first repetition of DB1 (Disability) - creates it if necessary</summary>
		public virtual DB1 getDB1()
		{
			DB1 ret = null;
			try
			{
				ret = (DB1) this.get_Renamed("DB1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DB1
		/// (Disability) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DB1 getDB1(int rep)
		{
			return (DB1) this.get_Renamed("DB1", rep);
		}
		
		/// <summary> Returns  first repetition of OBX (Observation/Result) - creates it if necessary</summary>
		public virtual OBX getOBX()
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
		
		/// <summary> Returns a specific repetition of OBX
		/// (Observation/Result) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
		}
	}
}