using System;
using System.Collections.Generic;
using System.Text;

namespace Canguro.Commands.View
{
    /// <summary>
    /// View Command to show the Axial component of the internal forces in elements.
    /// </summary>
    public class RenderS1 : Canguro.Commands.ViewCommand
    {
        private RenderS1() { }
        public static RenderS1 Instance = new RenderS1();

        /// <summary>
        /// This command is not interactive. Returns false.
        /// </summary>
        public override bool IsInteractive
        {
            get { return false; }
        }

        /// <summary>
        /// Executes the Non-Interactive Command.
        /// Sets the InternalForcesShown property of RenderOptions to Sx
        /// </summary>
        /// <param name="activeView">The Current Active View object</param>
        public override void  Run(Canguro.View.GraphicView activeView)
        {
            Canguro.View.Renderer.ModelRenderer mr = activeView.ModelRenderer;
            if (mr != null && mr.ForcesRenderer != null)
            {
                if (mr.RenderOptions.InternalForcesShown == Canguro.View.Renderer.RenderOptions.InternalForces.Sx)
                    mr.RenderOptions.InternalForcesShown = Canguro.View.Renderer.RenderOptions.InternalForces.None;
                else
                    mr.RenderOptions.InternalForcesShown = Canguro.View.Renderer.RenderOptions.InternalForces.Sx;
            }
        }
    }
}
