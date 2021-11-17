import React from "react"
import './Input.css'

function Input(props) {

    return (
        <label>
            <span>{props.label}</span>
            <input
                type={props.type}
                name={props.name}
                className={props.listeDesClasses}
            />
        </label>
    )
}

export default Input