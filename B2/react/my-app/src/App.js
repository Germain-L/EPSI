import logo from './logo.svg';
import './App.css';
import Input from './components/Input/Input.js';
import Nav from "./components/Nav/Nav.js";
import Button from './components/Button/Button.js';
import Form from './components/Form/Form.js';

function App() {
    return (
        <div className="App">
            <header className="App-header">
                <Nav
                    classes='links'
                    data={
                        [
                            { 'index': 'Accueil', 'href': '#' },
                            { 'index': 'A propos', 'href': '#' },
                            { 'index': 'Blog', 'href': '#' },
                            { 'index': 'Contact', 'href': '#' }
                        ]
                    }
                />
                <Button
                    className={null}
                    name="ta mère"
                    type="submit"
                    onClick={() => { console.log('clicked') }}
                />
                <img src={logo} className="App-logo" alt="logo" />
                <p>
                    Edit <code>src/App.js</code> and save to reload.
                </p>
                <a
                    className="App-link"
                    href="https://reactjs.org/"
                    target="_blank"
                    rel="noopener noreferrer"
                >
                    Learn React
                </a>
                <Input
                    label='Hugo'
                    name='hugo'
                    type='text'
                    ListeDesClasses='papa tonton tata'
                />

                <Input
                    label='Paul'
                    name='paul'
                    type='text'
                    ListeDesClasses='papa tonton tata'
                />
            </header>
            <Form button={{ 'name': 'Valider', 'type': 'submit' }} />
        </div>
    );
}

export default App;
