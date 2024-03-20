namespace dPosit.PayPal.Sdk.Models;

public enum PatchOperation
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Depending on the target location reference, completes one of these functions:<br/>
    ///     - the target location is an array index. Inserts a new value into the array at the specified index.<br/>
    ///     - the target location is an object parameter that does not already exist. Adds a new parameter to the object.<br/>
    ///     - the target location is an object parameter that does exist. Replaces that parameter's value.
    /// </summary>
    Add,
    /// <summary>
    /// Removes the value at the target location. For the operation to succeed, the target location must exist.
    /// </summary>
    Remove,
    /// <summary>
    /// Replaces the value at the target location with a new value. The operation object must contain a <c>value</c> parameter
    /// that defines the replacement value. For the operation to succeed, the target location must exist.
    /// </summary>
    Replace,
    /// <summary>
    /// Removes the value at a specified location and adds it to the target location. The operation object must contain a
    /// <c>from</c> parameter, which is a string that contains a JSON pointer value that references the location in the target document
    /// from which to move the value. For the operation to succeed, the <c>from</c> location must exist.
    /// </summary>
    Move,
    /// <summary>
    /// Copies the value at a specified location to the target location. The operation object must contain a <c>from</c> parameter,
    /// which is a string that contains a JSON pointer value that references the location in the target document from which to copy the
    /// value. For the operation to succeed, the <c>from</c> location must exist.
    /// </summary>
    Copy,
    /// <summary>
    /// Tests that a value at the target location is equal to a specified value. The operation object must contain a <c>value</c>
    /// parameter that defines the value to compare to the target location's value. For the operation to succeed, the target location
    /// must be equal to the <c>value</c> value. For test, <c>equal</c> indicates that the value at the target location and the value that
    /// <c>value</c> defines are of the same JSON type. The data type of the value determines how equality is defined:<br/>
    ///
    /// <list type="table">
    ///     <listheader>
    ///         <term>Type</term>
    ///         <description>Considered equal if both values</description>
    ///     </listheader>
    ///     <item>
    ///         <term><b>strings</b></term>
    ///         <description>Contain the same number of Unicode characters and their code points are byte-by-byte equal.</description>
    ///     </item>
    ///     <item>
    ///         <term><b>numbers</b></term>
    ///         <description>Are numerically equal.</description>
    ///     </item>
    ///     <item>
    ///         <term><b>arrays</b></term>
    ///         <description>
    ///             Contain the same number of values, and each value is equal to the value at the corresponding position in the
    ///             other array, by using these type-specific rules.
    ///         </description>
    ///     </item>
    ///     <item>
    ///         <term><b>objects</b></term>
    ///         <description>
    ///             Contain the same number of parameters, and each parameter is equal to a parameter in the other object,
    ///             by comparing their keys (as strings) and their values (by using these type-specific rules).
    ///         </description>
    ///     </item>
    ///     <item>
    ///         <term><b>literals (<c>false</c>, <c>true</c>, and <c>null</c>)</b></term>
    ///         <description>
    ///             Are the same. The comparison is a logical comparison. For example, whitespace between the parameter values of
    ///             an array is not significant. Also, ordering of the serialization of object parameters is not significant.
    ///         </description>
    ///     </item>
    /// </list>
    /// </summary>
    Test
}
