using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a RQC_I05 message structure (see chapter 11). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: QRD (Original-Style Query Definition) <b></b><br>
	/// 2: QRF (Original Style Query Filter) <b>optional </b><br>
	/// 3: RQC_I05_PROVIDER (a Group object) <b>repeating</b><br>
	/// 4: PID (Patient identification) <b></b><br>
	/// 5: NK1 (Next of kin / associated parties) <b>optional repeating</b><br>
	/// 6: GT1 (Guarantor) <b>optional repeating</b><br>
	/// 7: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RQC_I05:AbstractMessage
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
		/// <summary> Returns QRD (Original-Style Query Definition) - creates it if necessary</summary>
		virtual public QRD QRD
		{
			get
			{
				QRD ret = null;
				try
				{
					ret = (QRD) this.get_Renamed("QRD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QRF (Original Style Query Filter) - creates it if necessary</summary>
		virtual public QRF QRF
		{
			get
			{
				QRF ret = null;
				try
				{
					ret = (QRF) this.get_Renamed("QRF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RQC_I05_PROVIDER </summary>
		virtual public int PROVIDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROVIDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns the number of existing repetitions of NK1 </summary>
		virtual public int NK1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NK1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
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
		
		/// <summary> Creates a new RQC_I05 Group with custom ModelClassFactory.</summary>
		public RQC_I05(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RQC_I05 Group with DefaultModelClassFactory. </summary>
		public RQC_I05():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(RQC_I05_PROVIDER), true, true);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RQC_I05_PROVIDER (a Group object) - creates it if necessary</summary>
		public virtual RQC_I05_PROVIDER getPROVIDER()
		{
			RQC_I05_PROVIDER ret = null;
			try
			{
				ret = (RQC_I05_PROVIDER) this.get_Renamed("PROVIDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RQC_I05_PROVIDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RQC_I05_PROVIDER getPROVIDER(int rep)
		{
			return (RQC_I05_PROVIDER) this.get_Renamed("PROVIDER", rep);
		}
		
		/// <summary> Returns  first repetition of NK1 (Next of kin / associated parties) - creates it if necessary</summary>
		public virtual NK1 getNK1()
		{
			NK1 ret = null;
			try
			{
				ret = (NK1) this.get_Renamed("NK1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NK1
		/// (Next of kin / associated parties) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NK1 getNK1(int rep)
		{
			return (NK1) this.get_Renamed("NK1", rep);
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