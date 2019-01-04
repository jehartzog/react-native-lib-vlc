import React from 'react'
import { NativeModules } from 'react-native';

const { RNLibVlc } = NativeModules;

export default class LibVLC extends React.Component {
    render() {
        return (
            <RNLibVlc />
        );
    }
}
