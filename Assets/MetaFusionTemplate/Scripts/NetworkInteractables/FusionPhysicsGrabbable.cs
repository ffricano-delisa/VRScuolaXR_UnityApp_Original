/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 * All rights reserved.
 *
 * Licensed under the Oculus SDK License Agreement (the "License");
 * you may not use the Oculus SDK except in compliance with the License,
 * which is provided at the time of installation or download, or which
 * otherwise accompanies this software in either electronic or hard copy form.
 *
 * You may obtain a copy of the License at
 *
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Oculus SDK
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Oculus.Interaction;
using System;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Serialization;

namespace Chiligames.MetaFusionTemplate
{
    public class FusionPhysicsGrabbable : PhysicsGrabbable
    {
        Grabbable grabbable;

        protected override void Start()
        {
            base.Start();
        }

        protected override void OnEnable()
        {
            if (_started)
            {
                grabbable = GetComponent<Grabbable>();
                grabbable.WhenPointerEventRaised += CustomHandlePointerEventRaised;
            }
        }

        protected override void OnDisable()
        {
            if (_started)
            {
                grabbable.WhenPointerEventRaised -= CustomHandlePointerEventRaised;
            }
        }

        private void CustomHandlePointerEventRaised(PointerEvent evt)
        {

        }
    }
}
