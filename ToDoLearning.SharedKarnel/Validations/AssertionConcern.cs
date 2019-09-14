using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ToDoLearning.SharedKarnel.Events;

namespace ToDoLearning.SharedKarnel.Validations
{
    public class AssertionConcern
    {
        public static bool IsValid(params DomainNotification[] validations)
        {
            var notificationsNotNull = validations.Where(validation => validation != null);
            NotifyAll(notificationsNotNull);

            return notificationsNotNull.Count().Equals(0);
        }

        public static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications.ToList().ForEach(validation =>
            {
                DomainEvent.Raise<DomainNotification>(validation);
            });
        }

        public static DomainNotification AssertLength(string stringValue, int minimum, int maximum, string message)
        {
            int length = stringValue.Trim().Length;

            return (length < minimum || length > maximum) ? new DomainNotification("AssertArgumentLength", message) : null;
        }

        public static DomainNotification AssertNotNull(object object1, string message)
        {
            return (object1 == null) ? new DomainNotification("AssertArgumentNotNull", message) : null;
        }

        public static DomainNotification AssertEmailIsValid(string email, string message)
        {
            Regex validateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");            
            return validateEmail.IsMatch(email) == false ? new DomainNotification("AssertEmailIsValid", message) : null;
        }
    }
}
