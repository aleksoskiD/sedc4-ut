QUnit.test( "testing type coercion of integer to string", function( assert ) {
  assert.ok( 1 == "1", "Passed!" );
});

QUnit.test( "testing integer and string comparisson without type coersion", function( assert ) {
  assert.ok( 1 === "1", "Passed!" );
});