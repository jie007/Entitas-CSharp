//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherComponentWithFields;

    public static IMatcher<TestEntity> ComponentWithFields {
        get {
            if(_matcherComponentWithFields == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.ComponentWithFields);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherComponentWithFields = matcher;
            }

            return _matcherComponentWithFields;
        }
    }
}