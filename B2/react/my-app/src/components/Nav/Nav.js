import React from "react";
import './Nav.css';

function Nav(props) {


    return(
        <nav>
            <ul>
                {props.data.map((value, i) =>
                    <li key={i}>
                    <a
                        href={value.href}
                        className={props.classes}
                    >
                        {value.index}</a>
                    </li>
                )}
            </ul>
        </nav>
    )
}


export default Nav