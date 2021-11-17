import React from "react";
import './Form.css'
import Input from "../Input/Input";
import Button from "../Button/Button";

function Form(props) {

    return(
        <form method={props.method} action={props.action}>
            {props.refs.inputs.map((row, i) =>
                <Input
                    key={i}
                    label={row.label}
                    name={row.name}
                    type={row.type}
                    listeDesClasses={row.className}
                />
            )}
            <Button
                type={props.refs.button.type}
                name={props.refs.button.name}
                className={props.refs.button.className}
            />
        </form>
    )
}

export default Form