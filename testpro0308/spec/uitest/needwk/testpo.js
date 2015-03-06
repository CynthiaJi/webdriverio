/**
 * Created by online on 6/03/15.
 */

describe('angularjs homepage', function() {
    it('should greet the named user', function() {
        var angularHomepage = new AngularHomepage();
        angularHomepage.get();

        angularHomepage.setName('Julie');

        expect(angularHomepage.greeting.getText()).toEqual('Hello Julie!');
    });
});