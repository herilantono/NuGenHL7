using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PPG_PCG_GOAL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: GOL (Goal Detail) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 2: VAR (Variance) <b>optional repeating</b><br>
	/// 3: PPG_PCG_GOAL_ROLE (a Group object) <b>optional repeating</b><br>
	/// 4: PPG_PCG_GOAL_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 5: PPG_PCG_PROBLEM (a Group object) <b>optional repeating</b><br>
	/// 6: PPG_PCG_ORDER (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPG_PCG_GOAL:AbstractGroup
	{
		/// <summary> Returns GOL (Goal Detail) - creates it if necessary</summary>
		virtual public GOL GOL
		{
			get
			{
				GOL ret = null;
				try
				{
					ret = (GOL) this.get_Renamed("GOL");
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
		/// <summary> Returns the number of existing repetitions of VAR </summary>
		virtual public int VARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("VAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_GOAL_ROLE </summary>
		virtual public int GOAL_ROLEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GOAL_ROLE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_GOAL_OBSERVATION </summary>
		virtual public int GOAL_OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GOAL_OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_PROBLEM </summary>
		virtual public int PROBLEMReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROBLEM").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PPG_PCG_GOAL Group.</summary>
		public PPG_PCG_GOAL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(GOL), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
				this.add(typeof(PPG_PCG_GOAL_ROLE), false, true);
				this.add(typeof(PPG_PCG_GOAL_OBSERVATION), false, true);
				this.add(typeof(PPG_PCG_PROBLEM), false, true);
				this.add(typeof(PPG_PCG_ORDER), false, true);
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
		
		/// <summary> Returns  first repetition of VAR (Variance) - creates it if necessary</summary>
		public virtual VAR getVAR()
		{
			VAR ret = null;
			try
			{
				ret = (VAR) this.get_Renamed("VAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VAR
		/// (Variance) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VAR getVAR(int rep)
		{
			return (VAR) this.get_Renamed("VAR", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_GOAL_ROLE (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_GOAL_ROLE getGOAL_ROLE()
		{
			PPG_PCG_GOAL_ROLE ret = null;
			try
			{
				ret = (PPG_PCG_GOAL_ROLE) this.get_Renamed("GOAL_ROLE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_GOAL_ROLE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_GOAL_ROLE getGOAL_ROLE(int rep)
		{
			return (PPG_PCG_GOAL_ROLE) this.get_Renamed("GOAL_ROLE", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_GOAL_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_GOAL_OBSERVATION getGOAL_OBSERVATION()
		{
			PPG_PCG_GOAL_OBSERVATION ret = null;
			try
			{
				ret = (PPG_PCG_GOAL_OBSERVATION) this.get_Renamed("GOAL_OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_GOAL_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_GOAL_OBSERVATION getGOAL_OBSERVATION(int rep)
		{
			return (PPG_PCG_GOAL_OBSERVATION) this.get_Renamed("GOAL_OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_PROBLEM (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_PROBLEM getPROBLEM()
		{
			PPG_PCG_PROBLEM ret = null;
			try
			{
				ret = (PPG_PCG_PROBLEM) this.get_Renamed("PROBLEM");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_PROBLEM
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_PROBLEM getPROBLEM(int rep)
		{
			return (PPG_PCG_PROBLEM) this.get_Renamed("PROBLEM", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_ORDER (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_ORDER getORDER()
		{
			PPG_PCG_ORDER ret = null;
			try
			{
				ret = (PPG_PCG_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_ORDER getORDER(int rep)
		{
			return (PPG_PCG_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}