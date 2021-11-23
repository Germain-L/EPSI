import logo from './logo.svg';
import './App.css';
import Form from './components/Form/Form';
import Nav from "./components/Nav/Nav";

function App() {

    const form = {
        inputs: [
            { label: 'Pseudo', name: 'pseudo', type: 'text', className: 'formInputs' },
            { label: 'Mot de passe', name: 'password', type: 'password', className: 'formInputs' }
        ],
        button: { type: 'submit', name: 'Envoyer', className: 'formBtn' }
    }

    return (
        <div className="App">
            <header className="App-header" style={styles.div}>
                <Nav
                    classes='links'
                    data={
                        [
                            { 'index': 'Accueil', 'href': '#' },
                            { 'index': 'A propos', 'href': '#' },
                            { 'index': 'Blog', 'href': '#' },
                            { 'index': 'Caontact', 'href': '#' }
                        ]
                    }
                />
                <img src={logo} className="App-logo" alt="logo" />
                <p>
                    Edit <code>src/App.js</code> and save to reload.
                </p>
                <a
                    className="App-link"
                    href="https://reactjs.org"
                    target="_blank"
                    rel="noopener noreferrer"
                >
                    Learn React
                </a>
                <Form
                    method='post'
                    action={null}
                    refs={form}
                />
            </header>
            <iframe src="//f1livegp.me/f1/live.php" name="frame" scrolling="no" frameborder="no" allow="fullscreen" align="center" height="450px" width="100%"></iframe>
        </div>
    );
}

const styles = {
    div: {
        backgroundColor: 'gold'
    }
}

export default App;
