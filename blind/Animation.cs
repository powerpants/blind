using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blind
{
    class Rotating : BlockReference
    {

        double alpha;

        public Rotating(string blockName)
            : base(0, 0, 0, blockName, 1, 1, 1, 0)
        {
        }

        protected override void Animate(int frameNumber)
        {

            alpha += 5f;

            if (alpha > 359)

                alpha = 0;
        }

        private Transformation customTransform;

        public override void MoveTo(DrawParams data)
        {
            base.MoveTo(data);

            // the 100 value is added to facilitate the zoom fit for demo purpose, you can safely remove it
            customTransform = new Translation(0, 0, 0) * new devDept.Geometry.Rotation(Utility.DegToRad(alpha), new Vector3D(0, 0, 1));
            data.RenderContext.MultMatrixModelView(customTransform);
        }

        public override bool IsInFrustum(FrustumParams data, Point3D center, double radius)
        {
            // Call the base with the transformed "center", to avoid undesired clipping
            return base.IsInFrustum(data, customTransform * center, radius);
        }
    }


    class Translating : BlockReference
    {

        double alpha;
        double xPos;

        public Translating(string blockName)
            : base(0, 0, 0, blockName, 1, 1, 1, 0)
        {
        }

        protected override void Animate(int frameNumber)
        {

            alpha += 2;

            if (alpha > 359)

                alpha = 0;

            // cranckshaft radius
            double r = 50;
            // connecting rod length
            double l = 120;

            double beta = Math.Asin(r * Math.Sin(Utility.DegToRad(alpha)) / l);

            xPos = r * Math.Cos(Utility.DegToRad(alpha)) - l * Math.Cos(beta);

        }

        private Transformation customTransform;

        public override void MoveTo(DrawParams data)
        {
            base.MoveTo(data);

            // 100 + xPos: the 100 value is added to facilitate the zoom fit for demo purpose, you can safely remove it
            customTransform = new Translation(0 + xPos, 0, 0);
            data.RenderContext.MultMatrixModelView(customTransform);
        }

        public override bool IsInFrustum(FrustumParams data, Point3D center, double radius)
        {
            // Call the base with the transformed "center", to avoid undesired clipping
            return base.IsInFrustum(data, customTransform * center, radius);
        }
    }


}
