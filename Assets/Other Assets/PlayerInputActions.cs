// GENERATED AUTOMATICALLY FROM 'Assets/Other Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerInp_legacy"",
            ""id"": ""3cbb6e20-b5a7-4449-9015-8d4ea7f0363f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""09f18677-46e5-48d7-a684-613a56f865a8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""fbe78dbf-0803-4edf-b9b4-3b8ed828e6e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim_Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""6fc3d41c-d4bf-4ed5-a1c9-2f724ab4dbfe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""19296251-b8da-4ab5-94bd-073ade4acf63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire2"",
                    ""type"": ""Button"",
                    ""id"": ""117149d2-acdb-4ef5-928c-c256e4f546c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""0c6234c6-c158-41e5-81de-264cfefb8b20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""37dd3d55-11ef-408a-bd8d-6ea5b5768144"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""98097158-e9a3-4c2f-92da-41c75c946d58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""286ba00d-940d-490e-a96b-f5422d8d1753"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""71c7f58a-c6f4-4362-887c-93dfa3e02887"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeba0de0-5d78-4f65-85c2-ea60322d4798"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""da7fb444-ff64-426d-b520-411ec51fd046"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dc4481ce-3717-4566-b311-1d111e162734"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6369ce76-0d40-4fd9-a5cd-54c08e4be951"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4fd62e9f-afe7-4498-9e52-d4f27cd4fe78"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c69abc82-da07-47b7-8edb-519bca533869"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b6e86656-97d7-48b4-9c45-5bafcd294e37"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,NormalizeVector2"",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62b5f62f-b01d-40fc-98a4-a399c5f42a7c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5dbe1af-8740-480b-86e0-cb13586b22c5"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e7f4760-bbce-452c-9bd3-5bec51c10b5c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e6f7c1b-a14f-46fc-8fd4-1976ed5e4990"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8254954d-94a1-437c-b33c-320e4f702c70"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96665435-a7d7-4454-8fca-7de948634650"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Fire2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11fbba95-4e8b-43ad-982d-f2e5f22a7b3b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Fire2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7761b75c-9797-4bb9-9a79-4f9344ae0fd5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fc117a7-469c-4232-9bf9-9d9b88b169d3"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a57f5d1f-b00d-494c-b563-54a6e83dd023"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04b4fc39-5e42-4c86-bfb3-372364a48b6d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a624b70b-ef3a-4e4c-868b-4ffc56fd7650"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Aim_Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""973a8af7-8ade-47e7-b37c-03dcbbab1fe2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""78f91e6d-3305-4abb-8856-ae42c531b6b0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""dbbcf42a-8785-46f0-b4a1-c76e3b38d2ca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""69b6119e-fed9-41da-b3b2-6d1aa58d290e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire2"",
                    ""type"": ""Button"",
                    ""id"": ""e06fc319-1160-4632-a33a-45accfa5b4c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""30d6d21e-c52c-4663-9732-2731ac7b5696"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GameMenu"",
                    ""type"": ""Button"",
                    ""id"": ""699bf5dd-1263-4197-9793-e9406231f371"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SystemPause"",
                    ""type"": ""Button"",
                    ""id"": ""6d90b60c-2187-4b54-a0da-b5c9fc289ba1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""8fcf1e36-7d72-4cb0-8c21-9a2b6659c0b8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""63dea2d3-0f36-47c2-9599-7d115648716b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ef8599a6-a3f9-46e8-b27e-33bc15b6f9f5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""18c393d4-fcf3-47c0-8c8e-df396cc68cad"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee708f1b-969f-422a-915b-387a0e92dbb8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""668f34f6-75bd-490d-9455-ba6dbb9b648f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,NormalizeVector2"",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e767bfb3-541b-41c2-8423-ac72a747055f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3616857b-bedc-4622-8f7d-845274d1e5f1"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4db23b6-81a9-482d-a5f3-715e93f374c0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad7e3664-3b85-470c-b186-4852dcd1dbe4"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6f4163f-f74e-4fa5-8e79-e39091d7a078"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Fire2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""070ffb35-c736-4d98-881e-fe02f521b264"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Fire2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c1e5d23-1865-40ac-9fb7-2d220fcb9856"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89d64388-dac8-416e-a5ec-146e0f53a4fa"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""425028f8-f994-4a8a-98ac-e14561dfd61b"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""GameMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d8620b8-963d-42f0-8e9f-36709ad9b8ac"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""GameMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a50f5458-16b8-4bba-9838-d8297c8887e6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SystemPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1232bbe3-fe0d-4382-be9f-7265a4b658f5"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XBOX_Controller"",
                    ""action"": ""SystemPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XBOX_Controller"",
            ""bindingGroup"": ""XBOX_Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerInp_legacy
        m_PlayerInp_legacy = asset.FindActionMap("PlayerInp_legacy", throwIfNotFound: true);
        m_PlayerInp_legacy_Move = m_PlayerInp_legacy.FindAction("Move", throwIfNotFound: true);
        m_PlayerInp_legacy_Aim = m_PlayerInp_legacy.FindAction("Aim", throwIfNotFound: true);
        m_PlayerInp_legacy_Aim_Mouse = m_PlayerInp_legacy.FindAction("Aim_Mouse", throwIfNotFound: true);
        m_PlayerInp_legacy_Fire = m_PlayerInp_legacy.FindAction("Fire", throwIfNotFound: true);
        m_PlayerInp_legacy_Fire2 = m_PlayerInp_legacy.FindAction("Fire2", throwIfNotFound: true);
        m_PlayerInp_legacy_Reload = m_PlayerInp_legacy.FindAction("Reload", throwIfNotFound: true);
        m_PlayerInp_legacy_Menu = m_PlayerInp_legacy.FindAction("Menu", throwIfNotFound: true);
        m_PlayerInp_legacy_Dash = m_PlayerInp_legacy.FindAction("Dash", throwIfNotFound: true);
        m_PlayerInp_legacy_Pause = m_PlayerInp_legacy.FindAction("Pause", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Fire2 = m_Player.FindAction("Fire2", throwIfNotFound: true);
        m_Player_Dash = m_Player.FindAction("Dash", throwIfNotFound: true);
        m_Player_GameMenu = m_Player.FindAction("GameMenu", throwIfNotFound: true);
        m_Player_SystemPause = m_Player.FindAction("SystemPause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerInp_legacy
    private readonly InputActionMap m_PlayerInp_legacy;
    private IPlayerInp_legacyActions m_PlayerInp_legacyActionsCallbackInterface;
    private readonly InputAction m_PlayerInp_legacy_Move;
    private readonly InputAction m_PlayerInp_legacy_Aim;
    private readonly InputAction m_PlayerInp_legacy_Aim_Mouse;
    private readonly InputAction m_PlayerInp_legacy_Fire;
    private readonly InputAction m_PlayerInp_legacy_Fire2;
    private readonly InputAction m_PlayerInp_legacy_Reload;
    private readonly InputAction m_PlayerInp_legacy_Menu;
    private readonly InputAction m_PlayerInp_legacy_Dash;
    private readonly InputAction m_PlayerInp_legacy_Pause;
    public struct PlayerInp_legacyActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerInp_legacyActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerInp_legacy_Move;
        public InputAction @Aim => m_Wrapper.m_PlayerInp_legacy_Aim;
        public InputAction @Aim_Mouse => m_Wrapper.m_PlayerInp_legacy_Aim_Mouse;
        public InputAction @Fire => m_Wrapper.m_PlayerInp_legacy_Fire;
        public InputAction @Fire2 => m_Wrapper.m_PlayerInp_legacy_Fire2;
        public InputAction @Reload => m_Wrapper.m_PlayerInp_legacy_Reload;
        public InputAction @Menu => m_Wrapper.m_PlayerInp_legacy_Menu;
        public InputAction @Dash => m_Wrapper.m_PlayerInp_legacy_Dash;
        public InputAction @Pause => m_Wrapper.m_PlayerInp_legacy_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInp_legacy; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInp_legacyActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInp_legacyActions instance)
        {
            if (m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnAim;
                @Aim_Mouse.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnAim_Mouse;
                @Aim_Mouse.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnAim_Mouse;
                @Aim_Mouse.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnAim_Mouse;
                @Fire.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnFire;
                @Fire2.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnFire2;
                @Fire2.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnFire2;
                @Fire2.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnFire2;
                @Reload.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnReload;
                @Menu.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnMenu;
                @Dash.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnDash;
                @Pause.started -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerInp_legacyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Aim_Mouse.started += instance.OnAim_Mouse;
                @Aim_Mouse.performed += instance.OnAim_Mouse;
                @Aim_Mouse.canceled += instance.OnAim_Mouse;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Fire2.started += instance.OnFire2;
                @Fire2.performed += instance.OnFire2;
                @Fire2.canceled += instance.OnFire2;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerInp_legacyActions @PlayerInp_legacy => new PlayerInp_legacyActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Fire2;
    private readonly InputAction m_Player_Dash;
    private readonly InputAction m_Player_GameMenu;
    private readonly InputAction m_Player_SystemPause;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Fire2 => m_Wrapper.m_Player_Fire2;
        public InputAction @Dash => m_Wrapper.m_Player_Dash;
        public InputAction @GameMenu => m_Wrapper.m_Player_GameMenu;
        public InputAction @SystemPause => m_Wrapper.m_Player_SystemPause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire2;
                @Fire2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire2;
                @Fire2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire2;
                @Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @GameMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @GameMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @GameMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @SystemPause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSystemPause;
                @SystemPause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSystemPause;
                @SystemPause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSystemPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Fire2.started += instance.OnFire2;
                @Fire2.performed += instance.OnFire2;
                @Fire2.canceled += instance.OnFire2;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @GameMenu.started += instance.OnGameMenu;
                @GameMenu.performed += instance.OnGameMenu;
                @GameMenu.canceled += instance.OnGameMenu;
                @SystemPause.started += instance.OnSystemPause;
                @SystemPause.performed += instance.OnSystemPause;
                @SystemPause.canceled += instance.OnSystemPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_XBOX_ControllerSchemeIndex = -1;
    public InputControlScheme XBOX_ControllerScheme
    {
        get
        {
            if (m_XBOX_ControllerSchemeIndex == -1) m_XBOX_ControllerSchemeIndex = asset.FindControlSchemeIndex("XBOX_Controller");
            return asset.controlSchemes[m_XBOX_ControllerSchemeIndex];
        }
    }
    public interface IPlayerInp_legacyActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnAim_Mouse(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnFire2(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnFire2(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnGameMenu(InputAction.CallbackContext context);
        void OnSystemPause(InputAction.CallbackContext context);
    }
}
