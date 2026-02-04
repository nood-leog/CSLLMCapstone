using Microsoft.AspNetCore.Components.Server.Circuits;

namespace CSLLMCapstone.Services
{
    public class UserSessionService : CircuitHandler
    {
        public int? UserId { get; set; }
        public string? UserEmail { get; set; }
        public string? UserName { get; set; }

        public bool IsLoggedIn => UserId.HasValue;

        public void SetUser(int userId, string email, string name)
        {
            UserId = userId;
            UserEmail = email;
            UserName = name;
        }

        public void ClearUser()
        {
            UserId = null;
            UserEmail = null;
            UserName = null;
        }

        public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            // Circuit opened - initialize if needed
            return base.OnCircuitOpenedAsync(circuit, cancellationToken);
        }

        public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            // Circuit closed - cleanup if needed
            ClearUser();
            return base.OnCircuitClosedAsync(circuit, cancellationToken);
        }
    }
}