using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a OSR_Q06 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: MSA (MSA - message acknowledgment segment) <b></b><br>
	/// 2: ERR (ERR - error segment) <b>optional </b><br>
	/// 3: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 4: QRD (QRD - original-style query definition segment) <b></b><br>
	/// 5: QRF (QRF - original style query filter segment) <b>optional </b><br>
	/// 6: OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI (a Group object) <b>optional </b><br>
	/// 7: DSC (DSC - Continuation pointer segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OSR_Q06:AbstractMessage
	{
		/// <summary> Returns MSH (MSH - message header segment) - creates it if necessary</summary>
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
		/// <summary> Returns MSA (MSA - message acknowledgment segment) - creates it if necessary</summary>
		virtual public MSA MSA
		{
			get
			{
				MSA ret = null;
				try
				{
					ret = (MSA) this.get_Renamed("MSA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ERR (ERR - error segment) - creates it if necessary</summary>
		virtual public ERR ERR
		{
			get
			{
				ERR ret = null;
				try
				{
					ret = (ERR) this.get_Renamed("ERR");
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
		/// <summary> Returns QRD (QRD - original-style query definition segment) - creates it if necessary</summary>
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
		/// <summary> Returns QRF (QRF - original style query filter segment) - creates it if necessary</summary>
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
		/// <summary> Returns OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI (a Group object) - creates it if necessary</summary>
		virtual public OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI
		{
			get
			{
				OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI ret = null;
				try
				{
					ret = (OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI) this.get_Renamed("PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DSC (DSC - Continuation pointer segment) - creates it if necessary</summary>
		virtual public DSC DSC
		{
			get
			{
				DSC ret = null;
				try
				{
					ret = (DSC) this.get_Renamed("DSC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OSR_Q06 Group with custom ModelClassFactory.</summary>
		public OSR_Q06(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new OSR_Q06 Group with DefaultModelClassFactory. </summary>
		public OSR_Q06():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ERR), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI), false, false);
				this.add(typeof(DSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
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
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
	}
}