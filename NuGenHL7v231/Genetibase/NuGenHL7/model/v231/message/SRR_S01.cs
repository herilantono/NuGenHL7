using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a SRR_S01 message structure (see chapter null). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: MSA (MSA - message acknowledgment segment) <b></b><br>
	/// 2: ERR (ERR - error segment) <b>optional </b><br>
	/// 3: SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class SRR_S01:AbstractMessage
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
		/// <summary> Returns SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE (a Group object) - creates it if necessary</summary>
		virtual public SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE
		{
			get
			{
				SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE ret = null;
				try
				{
					ret = (SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE) this.get_Renamed("SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SRR_S01 Group with custom ModelClassFactory.</summary>
		public SRR_S01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new SRR_S01 Group with DefaultModelClassFactory. </summary>
		public SRR_S01():base(new DefaultModelClassFactory())
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
				this.add(typeof(SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}