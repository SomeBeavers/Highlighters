interface TestRenamed {
    name: string;
    id: number;
}

const user: TestRenamed = ({
    username: "Hayes",
    id: 0,
}) as any;

var test = function() { var a: any = 1 }
