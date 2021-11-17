import react from "react";

import "./Button.css";

export default function Button(props) {
  return (
    <button
      className={props.className}
      type={props.type}
      onClick={props.onClick}
    >
      {props.name}
    </button>
  );
}
