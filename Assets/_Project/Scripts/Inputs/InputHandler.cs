using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Inputs
{
    [CreateAssetMenu(fileName = "Inputs", menuName = "Game/Input Handler")]
    public class InputHandler : ScriptableObject, GameInputs.IPlayerActions, GameInputs.IUIActions
    {
        private GameInputs inputs;

#region Events
        // Player
        public UnityAction<Vector2> MovementEvent;
        public UnityAction JumpEvent;
        public UnityAction SprintEvent;
        public UnityAction SprintCancelledEvent;
        public UnityAction InteractionEvent;
        public UnityAction<Vector2> LookEvent;
        public UnityAction PauseEvent;

        // UI
        public UnityAction ResumeEvent;
#endregion Events

        void OnEnable()
        {
            if (inputs == null)
            {
                inputs = new GameInputs();

                // Subscribe to input maps callbacks
                inputs.Player.AddCallbacks(this);
                inputs.UI.AddCallbacks(this);

                // Start game with the main action map enabled
                SetGameplay();
            }
        }

        void OnDisable()
        {
            // Disable all inputs and action maps
            inputs.Player.Disable();
            inputs.UI.Disable();
        }

#region Utilities
        private void SetGameplay()
        {
            // Enable main gameplay action map
            inputs.Player.Enable();

            // Disable other action maps
            inputs.UI.Disable();
        }

        private void SetUI()
        {
            // Enable UI action map
            inputs.UI.Enable();

            // Disable other action maps
            inputs.Player.Disable();
        }
#endregion Utilities

#region Player Map
        public void OnMovement(InputAction.CallbackContext context)
        {
            // Check every time a movement is being made
            MovementEvent?.Invoke(context.ReadValue<Vector2>());
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            // Check when the jump button is being pressed
            if (context.phase == InputActionPhase.Performed)
            {
                JumpEvent?.Invoke();
            }
        }

        public void OnSprint(InputAction.CallbackContext context)
        {
            // Check when the sprint button is being pressed or released
            switch (context.phase)
            {
                case InputActionPhase.Performed:
                    SprintEvent?.Invoke();
                    break;
                case InputActionPhase.Canceled:
                    SprintCancelledEvent?.Invoke();
                    break;
            }
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            // Check every time a camera movement is being made
            LookEvent?.Invoke(context.ReadValue<Vector2>());
        }

        public void OnInteract(InputAction.CallbackContext context)
        {
            // Check when the interaction button is being pressed
            if (context.phase == InputActionPhase.Performed)
            {
                InteractionEvent?.Invoke();
            }
        }

        public void OnPause(InputAction.CallbackContext context)
        {
            // Check when the game is being paused and change action map
            if (context.phase == InputActionPhase.Started)
            {
                PauseEvent?.Invoke();

                // Switch action map from Player to UI
                SetUI();
            }
        }
#endregion Player Map

#region UI Map
        public void OnResume(InputAction.CallbackContext context)
        {
            // Check when the game is being unpaused and change action map
            if (context.phase == InputActionPhase.Started)
            {
                ResumeEvent?.Invoke();

                // Switch back to last action map
                SetGameplay();
            }
        }
#endregion UI Map
    }
}