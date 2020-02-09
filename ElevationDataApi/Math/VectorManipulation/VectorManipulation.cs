﻿/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System.Numerics;

namespace ElevationDataAPI.VectorManipulation
{
    public class VectorManipulation
    {
        // @vectorToBeRotated a real vector in 3d space
        // @theta the angle of rotation in degrees
        // @return vectorToBeRotated rotated "theta" degrees about the Z axis
        public static Vector3 RotateAboutZAxis(Vector3 vectorToBeRotated, float theta)
        {
            var rotationMATIRX = Matrix4x4.CreateRotationZ(theta);
            return Vector3.Transform(vectorToBeRotated, rotationMATIRX);
        }

        // @vectorToTranlated a real vector in 3d space
        // @distance the distance of the translation
        // @return returnVector translated distance along y axis
        public static Vector3 TranslateAlongYAxis(Vector3 vectorToTranlated, float distance)
        {
            Vector3 returnVector = new Vector3();
            returnVector = vectorToTranlated;
            returnVector.Y += distance;
            return returnVector;
        }
    }
}