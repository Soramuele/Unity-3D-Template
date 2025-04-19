//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.0
//     from Assets/_Project/Scripts/GameInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    /// <summary>
    /// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/_Project/Scripts/GameInputs.inputactions".
    /// </summary>
    /// <remarks>
    /// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
    /// </remarks>
    /// <example>
    /// <code>
    /// using namespace UnityEngine;
    /// using UnityEngine.InputSystem;
    ///
    /// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
    /// public class Example : MonoBehaviour, MyActions.IPlayerActions
    /// {
    ///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
    ///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
    ///
    ///     void Awake()
    ///     {
    ///         m_Actions = new MyActions_Actions();              // Create asset object.
    ///         m_Player = m_Actions.Player;                      // Extract action map object.
    ///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
    ///     }
    ///
    ///     void OnDestroy()
    ///     {
    ///         m_Actions.Dispose();                              // Destroy asset object.
    ///     }
    ///
    ///     void OnEnable()
    ///     {
    ///         m_Player.Enable();                                // Enable all actions within map.
    ///     }
    ///
    ///     void OnDisable()
    ///     {
    ///         m_Player.Disable();                               // Disable all actions within map.
    ///     }
    ///
    ///     #region Interface implementation of MyActions.IPlayerActions
    ///
    ///     // Invoked when "Move" action is either started, performed or canceled.
    ///     public void OnMove(InputAction.CallbackContext context)
    ///     {
    ///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
    ///     }
    ///
    ///     // Invoked when "Attack" action is either started, performed or canceled.
    ///     public void OnAttack(InputAction.CallbackContext context)
    ///     {
    ///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
    ///     }
    ///
    ///     #endregion
    /// }
    /// </code>
    /// </example>
    public partial class @GameInputs: IInputActionCollection2, IDisposable
    {
        /// <summary>
        /// Provides access to the underlying asset instance.
        /// </summary>
        public InputActionAsset asset { get; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public @GameInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""05286a09-fe66-4c36-9fbe-2861b8a8e212"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3c43898b-83a7-482c-8b57-9622fcd63584"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""90cd101e-71f6-4f52-906b-b2297901b18d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""6ecc16ef-7e5f-4c39-85d1-f99d62dcc4f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""66604abd-9cd3-47a8-bf78-0372d124b142"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""72e514be-7bf7-44ca-be3e-55958364edc5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d8cac92a-fe62-4172-8191-66f1ac703033"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""05030086-ebff-4020-a7d3-e9ffcab7f5e5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c1834aa0-72e9-42c3-8c25-50de91f1f178"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9266fd62-244e-440a-8195-0707deccb863"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4ac3efb9-7758-41a3-ac9b-67d65e4aa008"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""20cd4763-c55e-4a04-9a9d-cd53b6a45ede"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f81fcfac-6653-4987-99a7-c190df4310f1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": "";Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72e1b0c7-3cf0-4359-ae2e-734a81593ce9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e98c1fd-ab86-4e92-8dc7-55926ce98d12"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f663d73-8cfd-4a8c-9e17-226304071f04"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d450c552-490c-4911-a238-457669b1dd14"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""240bdb1b-88db-49d0-a9bc-95ff0b2602bf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59a91e1d-324c-4833-a023-dc5f66f14bb7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e911d205-d9b1-45d6-a4f1-628128ec54ba"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d89c8e50-fe31-4790-a443-48bd952e0ff4"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fce05b2a-5ade-46ae-9b89-fe2bf104cf64"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d6c20b4-778e-4c50-8665-dc0500a13476"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,ScaleVector2(x=2,y=2)"",
                    ""groups"": "";Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""25a6e2dc-b837-4a1a-aaec-6edb6463b346"",
            ""actions"": [
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""e3b33f20-8e89-43f2-9a8c-56ef12a645e7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e4272b44-8f17-4a6b-9b6b-60d5ffa2a99b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee9c79b1-9838-4a17-aeba-be7133789213"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
            m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
            m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
            m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_Resume = m_UI.FindAction("Resume", throwIfNotFound: true);
        }

        ~@GameInputs()
        {
            UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, GameInputs.Player.Disable() has not been called.");
            UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, GameInputs.UI.Disable() has not been called.");
        }

        /// <summary>
        /// Destroys this asset and all associated <see cref="InputAction"/> instances.
        /// </summary>
        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
        public void Enable()
        {
            asset.Enable();
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
        public void Disable()
        {
            asset.Disable();
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
        public IEnumerable<InputBinding> bindings => asset.bindings;

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Player
        private readonly InputActionMap m_Player;
        private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
        private readonly InputAction m_Player_Movement;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Sprint;
        private readonly InputAction m_Player_Look;
        private readonly InputAction m_Player_Interact;
        private readonly InputAction m_Player_Pause;
        /// <summary>
        /// Provides access to input actions defined in input action map "Player".
        /// </summary>
        public struct PlayerActions
        {
            private @GameInputs m_Wrapper;

            /// <summary>
            /// Construct a new instance of the input action map wrapper class.
            /// </summary>
            public PlayerActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
            /// <summary>
            /// Provides access to the underlying input action "Player/Movement".
            /// </summary>
            public InputAction @Movement => m_Wrapper.m_Player_Movement;
            /// <summary>
            /// Provides access to the underlying input action "Player/Jump".
            /// </summary>
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            /// <summary>
            /// Provides access to the underlying input action "Player/Sprint".
            /// </summary>
            public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
            /// <summary>
            /// Provides access to the underlying input action "Player/Look".
            /// </summary>
            public InputAction @Look => m_Wrapper.m_Player_Look;
            /// <summary>
            /// Provides access to the underlying input action "Player/Interact".
            /// </summary>
            public InputAction @Interact => m_Wrapper.m_Player_Interact;
            /// <summary>
            /// Provides access to the underlying input action "Player/Pause".
            /// </summary>
            public InputAction @Pause => m_Wrapper.m_Player_Pause;
            /// <summary>
            /// Provides access to the underlying input action map instance.
            /// </summary>
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
            public void Enable() { Get().Enable(); }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
            public void Disable() { Get().Disable(); }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
            public bool enabled => Get().enabled;
            /// <summary>
            /// Implicitly converts an <see ref="PlayerActions" /> to an <see ref="InputActionMap" /> instance.
            /// </summary>
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            /// <summary>
            /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
            /// </summary>
            /// <param name="instance">Callback instance.</param>
            /// <remarks>
            /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
            /// </remarks>
            /// <seealso cref="PlayerActions" />
            public void AddCallbacks(IPlayerActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }

            /// <summary>
            /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
            /// </summary>
            /// <remarks>
            /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
            /// </remarks>
            /// <seealso cref="PlayerActions" />
            private void UnregisterCallbacks(IPlayerActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @Sprint.started -= instance.OnSprint;
                @Sprint.performed -= instance.OnSprint;
                @Sprint.canceled -= instance.OnSprint;
                @Look.started -= instance.OnLook;
                @Look.performed -= instance.OnLook;
                @Look.canceled -= instance.OnLook;
                @Interact.started -= instance.OnInteract;
                @Interact.performed -= instance.OnInteract;
                @Interact.canceled -= instance.OnInteract;
                @Pause.started -= instance.OnPause;
                @Pause.performed -= instance.OnPause;
                @Pause.canceled -= instance.OnPause;
            }

            /// <summary>
            /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="PlayerActions.UnregisterCallbacks(IPlayerActions)" />.
            /// </summary>
            /// <seealso cref="PlayerActions.UnregisterCallbacks(IPlayerActions)" />
            public void RemoveCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            /// <summary>
            /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
            /// </summary>
            /// <remarks>
            /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
            /// </remarks>
            /// <seealso cref="PlayerActions.AddCallbacks(IPlayerActions)" />
            /// <seealso cref="PlayerActions.RemoveCallbacks(IPlayerActions)" />
            /// <seealso cref="PlayerActions.UnregisterCallbacks(IPlayerActions)" />
            public void SetCallbacks(IPlayerActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        /// <summary>
        /// Provides a new <see cref="PlayerActions" /> instance referencing this action map.
        /// </summary>
        public PlayerActions @Player => new PlayerActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
        private readonly InputAction m_UI_Resume;
        /// <summary>
        /// Provides access to input actions defined in input action map "UI".
        /// </summary>
        public struct UIActions
        {
            private @GameInputs m_Wrapper;

            /// <summary>
            /// Construct a new instance of the input action map wrapper class.
            /// </summary>
            public UIActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
            /// <summary>
            /// Provides access to the underlying input action "UI/Resume".
            /// </summary>
            public InputAction @Resume => m_Wrapper.m_UI_Resume;
            /// <summary>
            /// Provides access to the underlying input action map instance.
            /// </summary>
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
            public void Enable() { Get().Enable(); }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
            public void Disable() { Get().Disable(); }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
            public bool enabled => Get().enabled;
            /// <summary>
            /// Implicitly converts an <see ref="UIActions" /> to an <see ref="InputActionMap" /> instance.
            /// </summary>
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            /// <summary>
            /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
            /// </summary>
            /// <param name="instance">Callback instance.</param>
            /// <remarks>
            /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
            /// </remarks>
            /// <seealso cref="UIActions" />
            public void AddCallbacks(IUIActions instance)
            {
                if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
            }

            /// <summary>
            /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
            /// </summary>
            /// <remarks>
            /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
            /// </remarks>
            /// <seealso cref="UIActions" />
            private void UnregisterCallbacks(IUIActions instance)
            {
                @Resume.started -= instance.OnResume;
                @Resume.performed -= instance.OnResume;
                @Resume.canceled -= instance.OnResume;
            }

            /// <summary>
            /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="UIActions.UnregisterCallbacks(IUIActions)" />.
            /// </summary>
            /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
            public void RemoveCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            /// <summary>
            /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
            /// </summary>
            /// <remarks>
            /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
            /// </remarks>
            /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
            /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
            /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
            public void SetCallbacks(IUIActions instance)
            {
                foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        /// <summary>
        /// Provides a new <see cref="UIActions" /> instance referencing this action map.
        /// </summary>
        public UIActions @UI => new UIActions(this);
        private int m_KeyboardSchemeIndex = -1;
        /// <summary>
        /// Provides access to the input control scheme.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputControlScheme" />
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        private int m_ControllerSchemeIndex = -1;
        /// <summary>
        /// Provides access to the input control scheme.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputControlScheme" />
        public InputControlScheme ControllerScheme
        {
            get
            {
                if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
                return asset.controlSchemes[m_ControllerSchemeIndex];
            }
        }
        /// <summary>
        /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Player" which allows adding and removing callbacks.
        /// </summary>
        /// <seealso cref="PlayerActions.AddCallbacks(IPlayerActions)" />
        /// <seealso cref="PlayerActions.RemoveCallbacks(IPlayerActions)" />
        public interface IPlayerActions
        {
            /// <summary>
            /// Method invoked when associated input action "Movement" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnMovement(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Jump" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnJump(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Sprint" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnSprint(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnLook(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Interact" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnInteract(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Pause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnPause(InputAction.CallbackContext context);
        }
        /// <summary>
        /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "UI" which allows adding and removing callbacks.
        /// </summary>
        /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
        public interface IUIActions
        {
            /// <summary>
            /// Method invoked when associated input action "Resume" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnResume(InputAction.CallbackContext context);
        }
    }
}
