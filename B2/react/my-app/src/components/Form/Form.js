import react from "react";
import Button from "../Button/Button";

import './Form.css';

export default function Form(props) {

    return (
        <form>
            <label>
                Name:
                <input type="text" />
            </label>
            <label>
                Email:
                <input type="text" />
            </label>
            <Button type={props.button.type} name={props.button.type} />
        </form>
    );

}