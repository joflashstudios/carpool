import { Selector } from 'testcafe';

fixture `Scaffold`
    .page `http://localhost:8080`;

test('Check property of element', async t => {
    const header = Selector('h1');

    await t.expect(header.innerText).eql('Welcome to Your Vue.js App', 'Incorrect header');
});